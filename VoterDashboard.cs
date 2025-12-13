using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VoterDashboard : Form
    {
        private VoterDTO voterDTO;

        public VoterDashboard(VoterDTO voter)
        {
            InitializeComponent();

            try
            {
                if (voter == null)
                    throw new Exception("Voter data is missing.");

                voterDTO = voter;

                // Load Voter Image
                if (!string.IsNullOrEmpty(voter.Voter.Image) && File.Exists(voter.Voter.Image))
                    voter_image.Image = System.Drawing.Image.FromFile(voter.Voter.Image);

                // Set Labels
                name_label.Text = $"{voter.Voter.FirstName} {voter.Voter.MiddleName} {voter.Voter.LastName}";
                status_label.Text = voter.Voter.Status ? "Status: Voted" : "Status: Not Voted";
                department_label.Text = voter.Department.DepartmentName.ToUpper();
                year_label.Text = "Year: " + voter.Voter.Year;
                section_label.Text = "Section: " + voter.Voter.Section;
                birthday_label.Text = "Birthdate: " + voter.Voter.BirthDate.ToShortDateString();
                contact_label.Text = "Contact Number: " + voter.Voter.ContactNumber;
                email_label.Text = "Email: " + voter.Voter.Email;

                // Handle Elections
                if (voter.Election == null)
                    HandleNoElection();
                else if (voter.Election.Status && !voter.Election.EndStatus)
                    HandleActiveElection();
                else
                    HandleEndedElection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard.\n" + ex.Message);
                this.Close();
            }
        }

        private void HandleNoElection()
        {
            status_election_label.Text = "Status: No Elections";
            election_name.Text = "YOUR DEPARTMENT HAS NO ACTIVE ELECTIONS";
            election_department_label.Text = "Unavailable";

            vote_now_bttn.Enabled = false;
            vote_now_bttn.Text = "No Election Available";

            live_results_flow.Controls.Add(new ResultLabelcs());
        }

        private void HandleActiveElection()
        {
            try
            {
                status_election_label.Text = "Started Now";
                election_name.Text = voterDTO.Election.ElectionName.ToUpper();
                election_department_label.Text = voterDTO.Department.DepartmentName.ToUpper();

                LoadDashboard();

                if (voterDTO.Voter.Status)
                    LoadLiveResults();
                else
                    live_results_flow.Controls.Add(new ResultLabelcs());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load active election.\n" + ex.Message);
            }
        }

        private void HandleEndedElection()
        {
            election_name.Text = "ELECTION HAS ENDED";
            vote_now_bttn.Enabled = false;
            vote_now_bttn.Text = "No Election Available";

            Label label = new Label
            {
                Text = "Election has ended",
                Font = new System.Drawing.Font("Century Gothic", 10, FontStyle.Bold),
                ForeColor = Color.Red
            };

            live_results_flow.Controls.Add(label);
        }

        public void LoadDashboard()
        {
            try
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
                }
                else
                {
                    vote_now_bttn.Enabled = false;
                    vote_now_bttn.Text = "Election is Inactive";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard controls.\n" + ex.Message);
            }
        }

        public void LoadLiveResults()
        {
            try
            {
                live_results_flow.Controls.Clear();

                foreach (var position in voterDTO.Positions)
                {
                    List<Candidate> candidates = voterDTO.Candidates
                        .Where(c => c.PositionId == position.PositionId)
                        .ToList();

                    live_results_flow.Controls.Add(
                        new LiveResults(
                            position.PositionName,
                            candidates,
                            new VotedCandidatesService().GetCandidatesAndVotes(voterDTO.Election.ElectionId)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load live results.\n" + ex.Message);
            }
        }

        private void vote_now_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                var voteNow = new VoteNow(
                    voterDTO.Positions,
                    voterDTO.Election.ElectionId,
                    voterDTO.Voter.VoterId,
                    voterDTO
                );

                voteNow.OnUpdateRequested += LoadDashboard;
                voteNow.OnUpdateRequested += LoadLiveResults;
                voteNow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open voting window.\n" + ex.Message);
            }
        }

        private void logout_icon_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("You have been logged out.");
                this.Hide();
                new Login().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out.\n" + ex.Message);
            }
        }

        private void view_ballot_icon_Click(object sender, EventArgs e)
        {
            try
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
                }
                else if (voterDTO.Election.Status && voterDTO.Election.EndStatus)
                {
                    MessageBox.Show("Election is already ended.");
                    return;
                }

                List<(string Position, string Candidate)> ballotData = new List<(string, string)>();
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

                string filename = $"eBallot_{voterDTO.Voter.FirstName}_{voterDTO.Voter.LastName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF File (*.pdf)|*.pdf",
                    FileName = filename
                };

                if (save.ShowDialog() == DialogResult.OK)
                    GenerateBallotPDF(save.FileName, ballotData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to view ballot.\n" + ex.Message);
            }
        }

        private void GenerateBallotPDF(string filePath, List<(string Position, string Candidate)> ballotData)
        {
            try
            {
                using (Document pdf = new Document(PageSize.A4, 40, 40, 40, 40))
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdf, fs);
                    pdf.Open();

                    // Add Logo
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

                    // Title
                    Paragraph title = new Paragraph("OFFICIAL eBALLOT SUMMARY\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20))
                    { Alignment = Element.ALIGN_CENTER };
                    pdf.Add(title);

                    pdf.Add(new Paragraph($"Election ID: {voterDTO.Election.ElectionId}", FontFactory.GetFont(FontFactory.HELVETICA, 12))
                    { Alignment = Element.ALIGN_CENTER });
                    pdf.Add(new Paragraph("\n"));

                    // Table
                    PdfPTable table = new PdfPTable(2) { WidthPercentage = 100 };
                    table.SetWidths(new float[] { 40, 60 });

                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    table.AddCell(new PdfPCell(new Phrase("Position", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase("Candidate", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY, HorizontalAlignment = Element.ALIGN_CENTER });

                    iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    foreach (var item in ballotData)
                    {
                        table.AddCell(new PdfPCell(new Phrase(item.Position, cellFont)));
                        table.AddCell(new PdfPCell(new Phrase(item.Candidate, cellFont)));
                    }

                    pdf.Add(table);
                    pdf.Add(new Paragraph("\n\n"));

                    // QR Code
                    try
                    {
                        string qrData =
                            $"Voter ID: {voterDTO.Voter.VoterId}\nElection ID: {voterDTO.Election.ElectionId}\nDate: {DateTime.Now}\nElection: {voterDTO.Election.ElectionName}";

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
                    }
                    catch { }

                    pdf.Add(new Paragraph("\n\n"));

                    // Signatures
                    iTextSharp.text.Font sigFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    Paragraph voterSig = new Paragraph($"\n\n{voterDTO.Voter.FirstName} {voterDTO.Voter.MiddleName} {voterDTO.Voter.LastName}\nVoter Signature", sigFont)
                    { Alignment = Element.ALIGN_LEFT };

                    Paragraph adminSig = new Paragraph("\n\nGLYZEL M. GALAGAR\nElection Commissioner", sigFont)
                    { Alignment = Element.ALIGN_RIGHT };

                    pdf.Add(voterSig);
                    pdf.Add(adminSig);
                    pdf.Add(new Paragraph("\n\n"));

                    // Footer
                    Paragraph footer = new Paragraph($"Generated by: eBoto | Date: {DateTime.Now}", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10))
                    { Alignment = Element.ALIGN_CENTER };
                    pdf.Add(footer);

                    pdf.Close();
                }

                MessageBox.Show("Your complete eBallot PDF has been downloaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate PDF.\n" + ex.Message);
            }
        }
    }
}
