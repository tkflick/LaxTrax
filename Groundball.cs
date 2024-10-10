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
    public partial class Groundball : Form
    {
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;

        public Groundball()
        {
            InitializeComponent();

            common.getTeamNames(ref homeTeam, ref visitingTeam);
            btnHomeTeam.Text = homeTeam;
            btnVisitingTeam.Text = visitingTeam;

            common.getGender(ref gender); 
        }

        #region " REGION: BUTTON CLICKS " 
        
        private void btnPlayerNumber_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            btnPlayerNumber.Text = userEnteredText;

            popup.Dispose();
        }

        private void btnHomeTeam_Click(object sender, EventArgs e)
        {
            string lPlayerNumber = btnPlayerNumber.Text;
            string lTeamName = btnHomeTeam.Text;
            string lPlayerName = common.getPlayerName(lTeamName, lPlayerNumber);

            logGroundBallWin(lPlayerName, lTeamName, "homeTeamID");

            //update the label on the main form with the groundball win
            updateMainFormLabel("home");

            faceoff f = new faceoff();
            f.Close();
            this.Hide();
        }

        private void btnVisitingTeam_Click(object sender, EventArgs e)
        {
            string lPlayerNumber = btnPlayerNumber.Text;
            string lTeamName = btnVisitingTeam.Text;
            string lPlayerName = common.getPlayerName(lTeamName, lPlayerNumber);

            logGroundBallWin(lPlayerName, lTeamName, "visitingTeamID");

            //update the label on the main form with the groundball win
            updateMainFormLabel("away");

            faceoff f = new faceoff();
            f.Close();
            this.Hide();
        }

        #endregion 

        private void logGroundBallWin(string vPlayerName, string vTeamName, string vWhichTeamID)
        {
            //log the stat for the player
            string sGameID = getGameInfo(vTeamName, gender, "gameID");
            string sTeamID = getGameInfo(vTeamName, gender, vWhichTeamID);
            string playerID = common.getPlayerID(sTeamID, vPlayerName);

            App_Code.logStats ls = new App_Code.logStats();
            ls.logPlayerStat("groundball_wins", sGameID, sTeamID, playerID);
        }

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
            try
            {
                //update the label on the main form with the groundball win
                Main fc = (Main)Application.OpenForms["Main"];
                string lTeamName; 
                Int16 i;
                if (vTeam == "home")
                {
                    i = Convert.ToInt16(fc.lblHomeGBalls.Text);
                    i++;
                    fc.lblHomeGBalls.Text = Convert.ToString(i);
                    lTeamName = btnHomeTeam.Text;
                }
                else
                {
                    i = Convert.ToInt16(fc.lblVisitGBalls.Text);
                    i++;
                    fc.lblVisitGBalls.Text = Convert.ToString(i);
                    lTeamName = btnVisitingTeam.Text;
                }

                // update the game summary table on the main form 
                addGameSummaryRow(lTeamName, "Groundball");
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
        }

        public void addGameSummaryRow(string vTeamName, string vAction)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            Main fc = (Main)Application.OpenForms["Main"];
            ListViewItem lvi = new ListViewItem();

            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;
            string lAction = vAction;
            string lTeam = vTeamName;
            string lPlayerNum = btnPlayerNumber.Text;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(lAction);
            lvi.SubItems.Add(lTeam);
            lvi.SubItems.Add(lPlayerNum);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }

        #endregion
    }
}
