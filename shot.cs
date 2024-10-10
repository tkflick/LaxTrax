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
    public partial class frmShot : Form
    {
        Main fc = (Main)Application.OpenForms["Main"];
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;
        private string activeTeamToLog;
        private string defendingTeam;

        public frmShot()
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
            activeTeamToLog = "homeTeamID";
            defendingTeam = visitingTeam; 

            btnVisitingTeam.Text = "";
            if (btnHomeTeam.Text == "")
            {
                btnHomeTeam.Text = homeTeam;
            }
        }

        private void btnVisitingTeam_Click(object sender, EventArgs e)
        {
            activeTeamToLog = "visitingTeamID";
            defendingTeam = homeTeam; 

            btnHomeTeam.Text = "";
            if (btnVisitingTeam.Text == "")
            {
                btnVisitingTeam.Text = visitingTeam;
            }
        }

        /// <summary>
        /// (s)he shoots and misses..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string lPlayerNumber = btnPlayerNumber.Text;
            string lTeamName;
            bool bHomeTeam; 

            if (btnHomeTeam.Text == "") 
            {
                lTeamName = btnVisitingTeam.Text;
                bHomeTeam = false;
            }
            else 
            {
                lTeamName = btnHomeTeam.Text;
                bHomeTeam = true;
            }

            string lPlayerName = common.getPlayerName(lTeamName, lPlayerNumber);

            // log the shot that wasn't a goal
            logAction(lPlayerName, lTeamName, activeTeamToLog, "shots");

            //update the label on the main form with the team shot
            if (bHomeTeam == true)
            {
                updateMainFormLabel("home", false, "");
            }
            else
            {
                updateMainFormLabel("away", false, "");
            }

            this.Hide();
        }

        /// <summary>
        /// stoned him/her!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string lPlayerNumber = btnPlayerNumber.Text;
            string lTeamName;
            string lTeamField;
            string lGoalieField;
            bool bHomeTeam; 

            if (btnHomeTeam.Text == "")
            {
                lTeamName = btnVisitingTeam.Text;
                lTeamField = "homeTeamID";
                lGoalieField = "homeGoalieID";
                bHomeTeam = false;
            }
            else
            {
                lTeamName = btnHomeTeam.Text;
                lTeamField = "visitingTeamID";
                lGoalieField = "visitingGoalieID";
                bHomeTeam = true;
            }

            string lPlayerName = common.getPlayerName(lTeamName, lPlayerNumber);

            // first, log the shot that wasn't a goal
            logAction(lPlayerName, lTeamName, activeTeamToLog, "shots");

            //then, log the save for the opposing goalie
            string goalieNumber = getGameInfo(defendingTeam, gender, lGoalieField);
            logAction(common.getPlayerName(defendingTeam, goalieNumber), defendingTeam, lTeamField, "save");

            //update the label on the main form with the team shot and save
            if (bHomeTeam == true)
            {
                updateMainFormLabel("home", true, goalieNumber);
            }
            else
            {
                updateMainFormLabel("away", true, goalieNumber);
            }

            this.Hide();
        }

        #endregion

        private void logAction(string vPlayerName, string vTeamName, string vWhichTeamID, string vAction)
        { 
            //log the stat for the player
            string sGameID = getGameInfo(vTeamName, gender, "gameID");
            string sTeamID = getGameInfo(vTeamName, gender, vWhichTeamID);
            string playerID = common.getPlayerID(sTeamID, vPlayerName);

            App_Code.logStats ls = new App_Code.logStats();
            ls.logPlayerStat(vAction, sGameID, sTeamID, playerID);
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

        private void updateMainFormLabel(string vTeam, bool vSave, string vGoalieNumber)
        {
            //update the label on the main form with the team shot
            string lCurrSummaryText = string.Empty;
            string lNewSummaryRow = string.Empty;
            string lTeamName;
            Int16 i;
            if (vTeam == "home")
            {
                i = Convert.ToInt16(fc.lblHomeShots.Text);
                i++;
                fc.lblHomeShots.Text = Convert.ToString(i);
                lTeamName = btnHomeTeam.Text;

                // update the game summary table on the main form with the shot
                addGameSummaryRow(lTeamName, "Shot on goal");
                
                if (vSave)
                {
                    i = Convert.ToInt16(fc.lblVisitSaves.Text);
                    i++;
                    fc.lblVisitSaves.Text = Convert.ToString(i);
                    lTeamName = visitingTeam;

                    // update the game summary table on the main form with the save
                    addGameSummaryRow(lTeamName, "SAVE", vGoalieNumber);
                }
            }
            else
            {
                i = Convert.ToInt16(fc.lblVisitShots.Text);
                i++;
                fc.lblVisitShots.Text = Convert.ToString(i);
                lTeamName = btnVisitingTeam.Text;

                // update the game summary table on the main form with the shot
                addGameSummaryRow(lTeamName, "Shot on goal");
                
                if (vSave)
                {
                    i = Convert.ToInt16(fc.lblHomeSaves.Text);
                    i++;
                    fc.lblHomeSaves.Text = Convert.ToString(i);
                    lTeamName = homeTeam;

                    // update the game summary table on the main form with the save
                    addGameSummaryRow(lTeamName, "SAVE", vGoalieNumber);
                }
            }
        }

        public void addGameSummaryRow(string vTeamName, string vAction)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            ListViewItem lvi = new ListViewItem();

            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;
            string lAction = vAction;
            string lTeam = vTeamName;
            string lPlayerNum = btnPlayerNumber.Text;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(vAction);
            lvi.SubItems.Add(vTeamName);
            lvi.SubItems.Add(btnPlayerNumber.Text);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }

        public void addGameSummaryRow(string vTeamName, string vAction, string vGoalieNumber)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            ListViewItem lvi = new ListViewItem();
            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(vAction);
            lvi.SubItems.Add(vTeamName);
            lvi.SubItems.Add(vGoalieNumber);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }
        #endregion 

    }
}
