using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VoterDashboard : Form
    {
        private VoterDTO voterDTO;
        public VoterDashboard(VoterDTO voter)
        {
            InitializeComponent();
            this.voterDTO = voter;

            voter_image.Image = System.Drawing.Image.FromFile(voter.Voter.Image);
            name_label.Text = voter.Voter.FirstName + " " + voter.Voter.MiddleName + " " + voter.Voter.LastName;
            status_label.Text = voter.Voter.Status ? "Status: Voted" : "Status: Not Voted";
            department_label.Text = "Department: " + voter.Department.DepartmentName;
            year_label.Text = "Year: " + voter.Voter.Year;
            section_label.Text = "Section: " + voter.Voter.Section;
            birthday_label.Text = "Birthdate: " + voter.Voter.BirthDate.ToShortDateString();
            contact_label.Text = "Contact Number: " + voter.Voter.ContactNumber;
            email_label.Text = "Email: " + voter.Voter.Email;
            department_label.Text = voter.Department.DepartmentName.ToUpper();

            if (voter.Election == null)
            { 
                status_election_label.Text = "";
                election_name.Text = "NO ELECTION CREATED";
                election_department_label.Text = "";
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "No Election Available";
  
                Label noElectionLabel = new Label();
                noElectionLabel.Text = "No Election Available";
                noElectionLabel.Font = new System.Drawing.Font("Century Gothic", 10, FontStyle.Bold);
                noElectionLabel.ForeColor = Color.Red;
                live_results_flow.Controls.Add(noElectionLabel);

            }else if(voter.Election.Status && !voter.Election.EndStatus)
            {
                status_election_label.Text = voter.Election.Status ? "Started Now" : "Not Yet Started";
                election_name.Text = voter.Election.ElectionName.ToUpper();
                election_department_label.Text = voter.Department.DepartmentName.ToUpper();
                LoadDashboard();
                if (voterDTO.Voter.Status)
                    LoadLiveResults();
                else
                    live_results_flow.Controls.Add(new ResultLabelcs("YOU NEED TO VOTE FIRST TO VIEW THE RESULT"));
            } else if (voter.Election.Status && voter.Election.EndStatus)
            {
                status_election_label.Text = "";
                election_name.Text = "ELECTION IS ALREADY ENDED";
                election_department_label.Text = "";
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "No Election Available";

                Label noElectionLabel = new Label();
                noElectionLabel.Text = "No Election Available";
                noElectionLabel.Font = new System.Drawing.Font("Century Gothic", 10, FontStyle.Bold);
                noElectionLabel.ForeColor = Color.Red;
                live_results_flow.Controls.Add(noElectionLabel);

            }

        }

        public void LoadDashboard()
        {
            if (voterDTO.Election.Status && !voterDTO.Election.EndStatus && !voterDTO.Voter.Status)
            {
                vote_now_bttn.Enabled = true;
                vote_now_bttn.Text = "Vote Now!";
            }
            else if (voterDTO.Election.Status && !voterDTO.Election.EndStatus && voterDTO.Voter.Status)
            {
                status_label.Text = voterDTO.Voter.Status ? "Status: Voted" : "Status: Not Voted";
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "Already Voted!";
                
            }else if(voterDTO.Election.Status && voterDTO.Election.EndStatus)
            {
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "No election available";
            }
            else
            {
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "Election is Inactive";
            }
        }

        public void LoadLiveResults()
        {
            live_results_flow.Controls.Clear();
            foreach (var position in voterDTO.Positions)
            {
                List<Candidate> candidates = new List<Candidate>();

                foreach (var candidate in voterDTO.Candidates)
                    if (candidate.PositionId == position.PositionId)
                        candidates.Add(candidate);

                live_results_flow.Controls.Add(new LiveResults(position.PositionName, candidates, new VotedCandidatesService().GetCandidatesAndVotes(voterDTO.Election.ElectionId)));
            }
        }

        private void vote_now_bttn_Click(object sender, EventArgs e)
        {
            var voteNow = new VoteNow(voterDTO.Positions, voterDTO.Election.ElectionId, voterDTO.Voter.VoterId, this.voterDTO);
            voteNow.OnUpdateRequested += LoadDashboard;
            voteNow.OnUpdateRequested += LoadLiveResults;
            voteNow.ShowDialog();
            
        }

        private void logout_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            new Login().ShowDialog();
        }

        private void view_ballot_icon_Click(object sender, EventArgs e)
        {
            if (!voterDTO.Voter.Status)
            {
                MessageBox.Show("You must vote first before viewing your ballot.");
                return;
            }
            if (voterDTO.Election == null)
            {
                MessageBox.Show("Election is not active.");
                return;
            }else if(voterDTO.Election.Status && voterDTO.Election.EndStatus)
            {
                MessageBox.Show("Election is already ended");
                return;
            }else

               { List<(string Position, string Candidate)> ballotData = new List<(string, string)>();

            Voter voter = new VotedCandidatesService().GetAllVotedCandidates(voterDTO.Voter.VoterId);
            foreach (var votedCandidate in voter.VotedCandidates)
            {
                Candidate candidate = new CandidateService().GetCandidate((int)votedCandidate.CandidateId);
                string positionName = new PositionService().GetPositionName(candidate.PositionId);
                ballotData.Add((positionName, candidate.CandidateName));
            }

            if (ballotData.Count == 0)
            {
                MessageBox.Show("Your ballot is empty.");
                return;
            }

            string filename = $"eBallot_{voterDTO.Voter.FirstName}_{voterDTO.Voter.LastName}_{DateTime.Now.Year}.pdf";

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File (*.pdf)|*.pdf";
            save.FileName = filename;

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
                Paragraph title = new Paragraph("OFFICIAL eBALLOT SUMMARY\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                pdf.Add(title);


                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40, 60 });

                iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                PdfPCell posHeader = new PdfPCell(new Phrase("Position", headerFont));
                PdfPCell candHeader = new PdfPCell(new Phrase("Candidate", headerFont));

                posHeader.BackgroundColor = BaseColor.LIGHT_GRAY;
                candHeader.BackgroundColor = BaseColor.LIGHT_GRAY;

                posHeader.HorizontalAlignment = Element.ALIGN_CENTER;
                candHeader.HorizontalAlignment = Element.ALIGN_CENTER;

                table.AddCell(posHeader);
                table.AddCell(candHeader);

                iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                foreach (var item in ballotData)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.Position, cellFont)));
                    table.AddCell(new PdfPCell(new Phrase(item.Candidate, cellFont)));
                }

                pdf.Add(table);
                pdf.Add(new Paragraph("\n\n"));

                string qrData =
                    $"Voter ID: {voterDTO.Voter.VoterId}\n" +
                    $"Date: {DateTime.Now}\n" +
                    $"Election: {voterDTO.Election.ElectionName}";

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

                Paragraph voterSig = new Paragraph(
                    $"\n\n{voterDTO.Voter.FirstName} {voterDTO.Voter.MiddleName} {voterDTO.Voter.LastName}\n" +
                    "Voter Signature",
                    sigFont
                );
                voterSig.Alignment = Element.ALIGN_LEFT;

                Paragraph adminSig = new Paragraph(
                    "\n\nGLYZEL M. GALAGAR\n" +
                    "Election Commissioner",
                    sigFont
                );
                adminSig.Alignment = Element.ALIGN_RIGHT;

                pdf.Add(voterSig);
                pdf.Add(adminSig);

                pdf.Add(new Paragraph("\n\n"));

                iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);
                Paragraph footer = new Paragraph(
                    $"Generated by: eBoto | Date: {DateTime.Now}",
                    footerFont
                );
                footer.Alignment = Element.ALIGN_CENTER;

                pdf.Add(footer);

                pdf.Close();

                    MessageBox.Show("Your complete eBallot PDF has been downloaded!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




    }
}
