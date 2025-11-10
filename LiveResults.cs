using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class LiveResults : UserControl
    {
        public LiveResults(string positionName, List <Candidate> candidates, List<CandidatesDTO> candidatesDTOs)
        {
            InitializeComponent();
            position_name_label.Text = positionName;

            int count = 0;
            foreach (Candidate candidate in candidates)
            {

                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = candidate.CandidateName,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
                };
                result_chart.Series.Add(series);
                foreach (var candidateDTO in candidatesDTOs)
                {
                   if (candidate.CandidateId == candidateDTO.CandidateId)
                   {
                       result_chart.Series[candidate.CandidateName].Points.AddXY(count++, candidateDTO.Count);
                       break;
                   }
                }
               
            }
            result_chart.Titles.Add($"Tally of Votes for {positionName[0] + positionName.Substring(1).ToLower()}");

        }
    }
}
