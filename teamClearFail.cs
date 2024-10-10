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
    public partial class teamClearFail : Form
    {
        Main fc = (Main)Application.OpenForms["Main"];
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;

        public teamClearFail()
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
            // log the failed clear
            logAction(string.Empty, btnHomeTeam.Text, "homeTeamID", "teamClear_failure");
            updateMainFormLabel("home");

            this.Hide();
        }

        private void btnVisitingTeam_Click(object sender, EventArgs e)
        {
            //log the failed clear
            logAction(string.Empty, btnHomeTeam.Text, "visitingTeamID", "teamClear_failure");
            updateMainFormLabel("away");

            this.Hide();
        }

        #endregion

        private void logAction(string vPlayerName, string vTeamName, string vWhichTeamID, string vAction)
        {
            //log the stat for the team
            string sGameID = getGameInfo(vTeamName, gender, "gameID");
            string sTeamID = getGameInfo(vTeamName, gender, vWhichTeamID);

            App_Code.logStats ls = new App_Code.logStats();
            ls.logPlayerStat(vAction, sGameID, sTeamID, string.Empty);
        }

        #region " REGION: HELPER FUNCTIONS " 

        private string getGameInfo(string vTeamName, string vGender, string vField)
        {
            string lRetVal = common.getGameInfo(vTeamName, vGender, vField); 
            if (lRetVal == "!!")
            {
                MessageBox.Show( vField + " not found!", "Error", MessageBoxButtons.OK);
                lRetVal = string.Empty; 
            }

            return lRetVal;
        }

        private void updateMainFormLabel(string vTeam)
        {
            //update the label on the main form with the failed clear
            string lTeamName; 
            Int16 i;
            if (vTeam == "home")
            {
                i = Convert.ToInt16(fc.lblHomeFailedClears.Text);
                i++;
                fc.lblHomeFailedClears.Text = Convert.ToString(i);
                lTeamName = btnHomeTeam.Text;
            }
            else
            {
                i = Convert.ToInt16(fc.lblVisitFailedClears.Text);
                i++;
                fc.lblVisitFailedClears.Text = Convert.ToString(i);
                lTeamName = btnVisitingTeam.Text;
            }

            // update the game summary table on the main form
            addGameSummaryRow(lTeamName, "failed to clear");
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
