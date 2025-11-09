using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VoteNow : Form
    {
        private List<Position> positions;
        private int electionId;
        public VoteNow(List<Position> positions, int electionId)
        {
            InitializeComponent();
            this.positions = positions;
            this.electionId = electionId;
            AddFlowEachPosition();
        }
        public void AddFlowEachPosition()
        {
            foreach (var position in positions)
            {
                int positionId = position.PositionId;
                string positionName = position.PositionName;

                if (new CandidateService().IsPosition(positionId, electionId))
                {
                    List <Candidate> candidates = new CandidateService().GetCandidate(positionId, electionId);
                    PositionFlowLayout positionFlowLayout = new PositionFlowLayout(positionName);

                    foreach (Candidate candidate in candidates)
                        positionFlowLayout.AddPositionPanel(new CandidatePanel(candidate));    
                    
                    vote_candidates_flow.Controls.Add(positionFlowLayout);

                }
            }
        }
    }
}
