using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace ScoreLaxia
{
    public partial class faceoff : Form
    {
        Main fc = (Main)Application.OpenForms["Main"];
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;

        public string EnteredText
        {
            get
            {
                //return (txtHomeFO.Text);
                return ("");
            }
        }

        public faceoff()
        {
            InitializeComponent();

            common.getTeamNames(ref homeTeam, ref visitingTeam);
            txtHomeTeam.Text = homeTeam;
            txtVisitingTeam.Text = visitingTeam;

            common.getGender(ref gender); 
        }

        #region " REGION: BUTTON CLICKS "

        private void button1_Click(object sender, EventArgs e)
        {
            // close this form and go to the ground ball form
            this.Hide();
            Groundball f = new Groundball();
            f.ShowDialog();
            //f.Show();
        }

        private void btnHomePlayer_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            //get the player name associated with the number
            btnHomePlayer.Text = userEnteredText;
            lblHomePlayer.Text = common.getPlayerName(homeTeam, userEnteredText);

            popup.Dispose();
        }

        private void btnVisitorPlayer_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            //get the player name associated with the number
            btnVisitorPlayer.Text = userEnteredText;
            lblVisitorPlayer.Text = common.getPlayerName(visitingTeam, userEnteredText);
            
            popup.Dispose();
        }

        private void btnHTFOWin_Click(object sender, EventArgs e)
        {
            //player that won the faceoff
            string playerNumber = btnHomePlayer.Text;

            //team of the faceoff winning player
            string teamName = txtHomeTeam.Text;

            //log the stat for the player
            string sGameID = getGameInfo(teamName, gender, "gameID");
            string sTeamID = getGameInfo(teamName, gender, "homeTeamID");
            string playerID = common.getPlayerID(sTeamID, lblHomePlayer.Text);

            App_Code.logStats ls = new App_Code.logStats();
            ls.logPlayerStat("faceoff_wins", sGameID, sTeamID, playerID);

            //update the label on the main form with the faceoff win
            updateMainFormLabel("home");

            // close this form and go to the ground ball form
            this.Hide();
            Groundball f = new Groundball();
            f.ShowDialog();
            //f.Show();
        }

        private void btnVTFOWin_Click(object sender, EventArgs e)
        {
            //player that won the faceoff
            string playerNumber = btnVisitorPlayer.Text;

            //team of the faceoff winning player
            string teamName = txtVisitingTeam.Text;

            //log the stat for the player
            string sGameID = getGameInfo(teamName, gender, "gameID");
            string sTeamID = getGameInfo(teamName, gender, "visitingTeamID");
            string playerID = common.getPlayerID(sTeamID, lblVisitorPlayer.Text);

            App_Code.logStats ls = new App_Code.logStats();
            ls.logPlayerStat("faceoff_wins", sGameID, sTeamID, playerID);

            //update the label on the main form with the faceoff win
            updateMainFormLabel("away");

            // close this form and go to the ground ball form
            this.Hide();
            Groundball f = new Groundball();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //home button
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //faceoff violation - stop the clock and penalty timers
            Main.frmObj.timer.Stop();
            fc.stopAllPenaltyTimers(); 

            foViolation f = new foViolation();
            f.ShowDialog();
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
            //update the label on the main form with the team shot
            string lTeamName;
            string lPlayerNum;
            Int16 i;
            if (vTeam == "home")
            {
                i = Convert.ToInt16(fc.lblHomeFOWins.Text);
                i++;
                fc.lblHomeFOWins.Text = Convert.ToString(i);
                lTeamName = txtHomeTeam.Text;
                lPlayerNum = btnHomePlayer.Text; 
            }
            else
            {
                i = Convert.ToInt16(fc.lblVisitFOWins.Text);
                i++;
                fc.lblVisitFOWins.Text = Convert.ToString(i);
                lTeamName = txtVisitingTeam.Text;
                lPlayerNum = btnVisitorPlayer.Text; 
            }

            // update the game summary table on the main form
            addGameSummaryRow(lTeamName, "Face off win", lPlayerNum); 
        }

        public void addGameSummaryRow(string vTeamName, string vAction, string vPlayerNum)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            ListViewItem lvi = new ListViewItem();

            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;
            string lAction = vAction;
            string lTeam = vTeamName;
            string lPlayerNum = vPlayerNum;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(lAction);
            lvi.SubItems.Add(lTeam);
            lvi.SubItems.Add(vPlayerNum);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }

        #endregion

        private void pbTimerStart_Click(object sender, EventArgs e)
        {
            //start the game timer
            Main.frmObj.timer.Start();
            //also restart any penalty times not yet expired
            fc.startAllPenaltyTimers(); 

            //disable the start button
            pbTimerStart.Enabled = false;
            //enable the stop button
            pbTimerStop.Enabled = true;
        }

        private void pbTimerStop_Click(object sender, EventArgs e)
        {
            //stop the game timer
            Main.frmObj.timer.Stop();
            //also stop any penalty timers still running
            fc.stopAllPenaltyTimers(); 

            //disable the start button
            pbTimerStart.Enabled = true;
            //enable the stop button
            pbTimerStop.Enabled = false;
        }

    }
}
