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
        private WinnersService service;
        private ElectionDTO election;
        
        public EndedPanel(ElectionDTO electionDTO)
        {
            InitializeComponent();
            service = new WinnersService();
            department_name_label.Text = electionDTO.Department.DepartmentName;
            election_name_label.Text = electionDTO.Election.ElectionName.ToUpper();
            election = electionDTO;
            LoadWinners();
            
        }
        public void LoadWinners()
        {
            List<Winner> winners = election.Winners;
            if(winners.Count == 0)
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
        private void view_result_Click(object sender, EventArgs e)
        {
            new ElectionResults().ShowDialog();
        }

        private void download_bttn_Click(object sender, EventArgs e)
        {
            List<(string Position, string Candidate)> electionResult = new List<(string, string)>();

            foreach (var election in election.Winners)
            {
                Candidate candidate = new CandidateService().GetCandidate((int)election.CandidateId);
                string positionName = new PositionService().GetPositionName(candidate.PositionId);
                electionResult.Add((positionName, candidate.CandidateName));
            }

            if (electionResult.Count == 0)
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
                catch { }

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


                PdfPTable table = new PdfPTable(2)
                {
                    WidthPercentage = 100
                };
                table.SetWidths(new float[] { 40, 60 });

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
                table.AddCell(posHeader);
                table.AddCell(candHeader);

                iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                foreach (var item in electionResult)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.Position, cellFont)));
                    table.AddCell(new PdfPCell(new Phrase(item.Candidate, cellFont)));
                }

                pdf.Add(table);
                pdf.Add(new Paragraph("\n\n"));


                string qrData =
                    $"Election ID: {election.ElectionId}\n" +
                    $"Date: {DateTime.Now}\n" +
                    $"Election: {election.ElectionName}";

                using (var qrGen = new QRCoder.QRCodeGenerator())
                {
                    var qrCodeData = qrGen.CreateQrCode(qrData, QRCoder.QRCodeGenerator.ECCLevel.Q);
                    var qrCode = new QRCoder.QRCode(qrCodeData);
                    using (Bitmap qrBitmap = qrCode.GetGraphic(20))
                    using (MemoryStream ms = new MemoryStream())
                    {
                        qrBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image qrImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        qrImage.ScaleToFit(120f, 120f);
                        qrImage.Alignment = Element.ALIGN_LEFT;
                        pdf.Add(qrImage);
                    }
                }

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
    }
}
