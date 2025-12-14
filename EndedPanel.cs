using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class EndedPanel : UserControl
    {
        private WinnersService service = new WinnersService();
        private CandidateService candidateService = new CandidateService();
        private PositionService positionService = new PositionService();
        private VotedCandidatesService votedCandidatesService = new VotedCandidatesService();
        private ElectionDTO election;

        public EndedPanel(ElectionDTO electionDTO)
        {
            InitializeComponent();
            department_name_label.Text = electionDTO.Department.DepartmentName;
            election_name_label.Text = electionDTO.Election.ElectionName.ToUpper();
            election = electionDTO;
            LoadWinners();

        }
        public void LoadWinners()
        {
            try
            {
                List<Winner> winners = election.Winners;
                if (winners.Count == 0)
                {
                    winners_flow.Controls.Add(new Label()
                    {
                        Text = "No winners declared.",
                        AutoSize = true,
                        Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold),
                        ForeColor = Color.Red,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    });
                    this.Height = 116;
                    return;
                }
                foreach (var winner in winners)
                {
                    winners_flow.Controls.Add(new WinnerPanel(winner));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading winners: " + ex.Message);
            }
        }

        private void download_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                List<(string Position, string Candidate, int Count)> electionResultWinners = new List<(string, string, int)>();
                List<(string Position, string Candidate, int Count)> electionResultAll = new List<(string, string, int)>();

                foreach (var election in election.Candidates)
                {
                    Candidate candidate = candidateService.GetCandidate((int)election.CandidateId);
                    string positionName = positionService.GetPositionName(candidate.PositionId);
                    int count = votedCandidatesService.GetCandidateVoteCount((int)election.CandidateId, election.ElectionId);
                    electionResultAll.Add((positionName, candidate.CandidateName, count));
                }

                foreach (var election in election.Winners)
                {
                    Candidate candidate = candidateService.GetCandidate((int)election.CandidateId);
                    string positionName = positionService.GetPositionName(candidate.PositionId);
                    int count = election.Count;
                    electionResultWinners.Add((positionName, candidate.CandidateName, count));
                }

                if (electionResultWinners.Count == 0)
                {
                    MessageBox.Show("There are no winners declared");
                    return;
                }

                string filename = $"electionResult{election.ElectionName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF File (*.pdf)|*.pdf",
                    FileName = filename
                };

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document pdf = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(save.FileName, FileMode.Create));
                    pdf.Open();

                    try
                    {
                        string logoPath = "logo.png";
                        if (File.Exists(logoPath))
                        {
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                            logo.ScaleToFit(100f, 100f);
                            logo.Alignment = Element.ALIGN_CENTER;
                            pdf.Add(logo);
                        }
                    }
                    catch(Exception ex) {
                        MessageBox.Show("Error loading logo image: " + ex.Message);
                        return;
                    }

                    pdf.Add(new Paragraph("\n"));


                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    Paragraph title = new Paragraph("OFFICIAL eResult Summary\n\n", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdf.Add(title);


                    Paragraph electionIdPara = new Paragraph($"Election ID: {election.ElectionId}", FontFactory.GetFont(FontFactory.HELVETICA, 12))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdf.Add(electionIdPara);
                    pdf.Add(new Paragraph("\n"));


                    PdfPTable winnersTable = new PdfPTable(3)
                    {
                        WidthPercentage = 100
                    };
                    winnersTable.SetWidths(new float[] { 40, 60 , 40});

                    PdfPTable all = new PdfPTable(3)
                    {
                        WidthPercentage = 100
                    };
                    all.SetWidths(new float[] { 40, 60, 40 });

                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                    PdfPCell posHeader = new PdfPCell(new Phrase("Position", headerFont))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    PdfPCell candHeader = new PdfPCell(new Phrase("Candidate", headerFont))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    PdfPCell countHeader = new PdfPCell(new Phrase("No of Votes", headerFont))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    winnersTable.AddCell(posHeader);
                    winnersTable.AddCell(candHeader);
                    winnersTable.AddCell(countHeader);

                    all.AddCell(posHeader);
                    all.AddCell(candHeader);
                    all.AddCell(countHeader);

                    iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    foreach (var item in electionResultWinners)
                    {
                        winnersTable.AddCell(new PdfPCell(new Phrase(item.Position, cellFont)));
                        winnersTable.AddCell(new PdfPCell(new Phrase(item.Candidate, cellFont)));
                        winnersTable.AddCell(new PdfPCell(new Phrase(Convert.ToString(item.Count), cellFont)));

                    }
                    foreach (var item in electionResultAll)
                    {
                        all.AddCell(new PdfPCell(new Phrase(item.Position, cellFont)));
                        all.AddCell(new PdfPCell(new Phrase(item.Candidate, cellFont)));
                        all.AddCell(new PdfPCell(new Phrase(Convert.ToString(item.Count), cellFont)));

                    }
                    Paragraph winnersPara = new Paragraph("Election Winners", FontFactory.GetFont(FontFactory.HELVETICA, 12))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdf.Add(winnersPara);
                    pdf.Add(new Paragraph("\n\n"));
                    pdf.Add(winnersTable);
                    pdf.Add(new Paragraph("\n\n"));
                    Paragraph allPara = new Paragraph("Overall Result", FontFactory.GetFont(FontFactory.HELVETICA, 12))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdf.Add(allPara);
                    pdf.Add(new Paragraph("\n\n"));
                    pdf.Add(all);
                    pdf.Add(new Paragraph("\n\n"));


                    iTextSharp.text.Font sigFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    Paragraph adminSig = new Paragraph(
                        "\n\nGLYZEL M. GALAGAR\nElection Commissioner",
                        sigFont)
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    pdf.Add(adminSig);
                    pdf.Add(new Paragraph("\n\n"));

                    iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);
                    Paragraph footer = new Paragraph(
                        $"Generated by: eBoto | Date: {DateTime.Now}",
                        footerFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdf.Add(footer);

                    pdf.Close();

                    MessageBox.Show("Your complete eResult PDF has been downloaded!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);

            }
          
        }
       
    }
}
