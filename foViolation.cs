using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScoreLaxia
{
    public partial class foViolation : Form
    {
        Main fc = (Main)Application.OpenForms["Main"];
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;

        public foViolation()
        {
            InitializeComponent();

            common.getTeamNames(ref homeTeam, ref visitingTeam);
            btnHomeTeam.Text = homeTeam;
            btnVisitingTeam.Text = visitingTeam;

            common.getGender(ref gender); 
        }

        #region " REGION: BUTTON CLICKS " 

        private void btnHomeTeam_Click(object sender, EventArgs e)
        {
            updateMainFormLabel("home");
            this.Hide();
        }

        private void btnVisitingTeam_Click(object sender, EventArgs e)
        {
            updateMainFormLabel("away");
            this.Hide();
        }

        #endregion

        #region " REGION: HELPER FUNCTIONS "

        private string getGameInfo(string vTeamName, string vGender, string vField)
        {
            string lRetVal = common.getGameInfo(vTeamName, vGender, vField);
            if (lRetVal == "!!")
            {
                MessageBox.Show(vField + " not found!", "Error", MessageBoxButtons.OK);
                lRetVal = string.Empty;
            }
            return lRetVal;
        }

        private void updateMainFormLabel(string vTeam)
        {
            //update the label on the main form with the team clear
            string lTeamName;
            Int16 i;
            if (vTeam == "home")
            {
                i = Convert.ToInt16(fc.lblHomeClears.Text);
                i++;
                fc.lblHomeClears.Text = Convert.ToString(i);
                lTeamName = btnHomeTeam.Text;
            }
            else
            {
                i = Convert.ToInt16(fc.lblVisitClears.Text);
                i++;
                fc.lblVisitClears.Text = Convert.ToString(i);
                lTeamName = btnVisitingTeam.Text;
            }

            if (i == 3)
            {
                MessageBox.Show(lTeamName + " has committed 3 Faceoff Violations!", "Error", MessageBoxButtons.OK);
            }

            // update the game summary table on the main form
            addGameSummaryRow(lTeamName, "Faceoff Violation");
        }

        public void addGameSummaryRow(string vTeamName, string vAction)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            ListViewItem lvi = new ListViewItem();

            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;
            string lPlayerNum = string.Empty;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(vAction);
            lvi.SubItems.Add(vTeamName);
            lvi.SubItems.Add(lPlayerNum);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }

        #endregion


    }
}
