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
    public partial class penalty : Form
    {
        public Timer t; // = new Timer();
        public int seconds;

        Main fc = (Main)Application.OpenForms["Main"];
        App_Code.common common = new App_Code.common();
        private string homeTeam;
        private string visitingTeam;
        private string gender;
        private string activeTeam;
        private string activePlayerNum;
        private string activePlayerName;
        private string activePenalty;

        public penalty()
        {
            InitializeComponent();

            common.getTeamNames(ref homeTeam, ref visitingTeam);
            btnHomeTeam.Text = homeTeam;
            btnVisitingTeam.Text = visitingTeam;

            common.getGender(ref gender);

            popTimeDDL();
            popReleaseDDL();
            popPenaltyDDL();


        }

        private void penalty_Load(object sender, EventArgs e)
        {

        }

        #region "  REGION: BUTTON CICKS  " 

        private void btnHomeTeam_Click(object sender, EventArgs e)
        {
            activeTeam = "home";
            //show all the home team controls and the save button
            setControls("home", true);
            btnSave.Visible = true;
            //hide any away team controls that may be showing
            setControls("away", false);

        }

        private void btnVisitingTeam_Click(object sender, EventArgs e)
        {
            activeTeam = "away";
            //show all the away team controls and the save button
            setControls("away", true);
            btnSave.Visible = true;
            //hide and home team controls that may be showing
            setControls("home", false);

        }

        private void btnHomePlayerNumber_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            //get the player name associated with the number
            btnHomePlayerNumber.Text = userEnteredText;
            btnVisitorPlayerNumber.Text = string.Empty; 

            popup.Dispose();
        }

        private void btnVisitorPlayerNumber_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            //get the player name associated with the number
            btnVisitorPlayerNumber.Text = userEnteredText;
            btnHomePlayerNumber.Text = string.Empty; 
            
            popup.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateSave())
            {
                ComboBox activeComboBox;
                string teamToLogFor;

                if (btnHomePlayerNumber.Text == string.Empty)
                {
                    activeTeam = btnVisitingTeam.Text;
                    activePlayerNum = btnVisitorPlayerNumber.Text;
                    activeComboBox = ddlVisitorTime;
                    activePenalty = ddlVisitorPenalty.SelectedText;
                    updateMainFormLabel("away");
                    teamToLogFor = "visitingTeamID";
                }
                else
                {
                    activeTeam = btnHomeTeam.Text;
                    activePlayerNum = btnHomePlayerNumber.Text;
                    activeComboBox = ddlHomeTime;
                    activePenalty = ddlHomePenalty.SelectedText;
                    updateMainFormLabel("home");
                    teamToLogFor = "homeTeamID";
                }
                activePlayerName = common.getPlayerName(activeTeam, activePlayerNum);

                //log the stat for the player
                string sGameID = getGameInfo(activeTeam, gender, "gameID");
                string sTeamID = getGameInfo(activeTeam, gender, teamToLogFor);
                string playerID = common.getPlayerID(sTeamID, activePlayerName);

                App_Code.logStats ls = new App_Code.logStats();
                ls.logPlayerStat("penalties", sGameID, sTeamID, playerID);

                //---[ lets do the timer stuff now ]---
                t = setup_timer();
                seconds = Convert.ToInt16(activeComboBox.SelectedValue.ToString());

                //---[ adding timer to list: ]---
                addTimerToList(t);

                //---[ adding this timer to list<T>: ]---
                fc.listOfTimers.Add(t);

                //---[ start timer: actually, we don't want to start the timer right away, not until the game time resumes ]---
                //t.Start();

                // hide the form...
                this.Hide();

            }
            else
            {
                MessageBox.Show("Required items have not been filled out");
            }
        }

        #endregion 

        #region " REGION: HELPER FUNCTIONS "

        private void setControls(string vTeam, bool vAction)
        {
            switch (vTeam)
            {
                case "away":
                    {
                        btnVisitorPlayerNumber.Visible = vAction;
                        ddlVisitorPenalty.Visible = vAction;
                        ddlVisitorTime.Visible = vAction;
                        ddlVisitorRelease.Visible = vAction;
                        break;
                    }
                case "home":
                    {
                        btnHomePlayerNumber.Visible = vAction;
                        ddlHomePenalty.Visible = vAction;
                        ddlHomeTime.Visible = vAction;
                        ddlHomeRelease.Visible = vAction;
                        break;
                    }
            }
        }

        private void popTimeDDL()
        {
            ddlHomeTime.DisplayMember = "Text";
            ddlHomeTime.ValueMember = "Value";
            ddlVisitorTime.DisplayMember = "Text";
            ddlVisitorTime.ValueMember = "Value";
            var items = new[] 
            { 
                new { Text = "Select Time", Value = "00" }, 
                new { Text = "0:30", Value = "30" }, 
                new { Text = "1:00", Value = "60" }, 
                new { Text = "1:30", Value = "90" },
                new { Text = "2:00", Value = "120" }
            };
            ddlHomeTime.DataSource = items;
            ddlVisitorTime.DataSource = items; 
        }

        private void popReleaseDDL()
        { 
            ddlHomeRelease.DisplayMember = "Text";
            ddlHomeRelease.ValueMember = "Value";
            ddlVisitorRelease.DisplayMember = "Text";
            ddlVisitorRelease.ValueMember = "Value";

            var items = new[] 
            { 
                new { Text = "Releasable?", Value = "?" }, 
                new { Text = "Yes", Value = "Yes" }, 
                new { Text = "No", Value = "No" }
            };
            ddlHomeRelease.DataSource = items;
            ddlVisitorRelease.DataSource = items;
        }

        private void popPenaltyDDL()
        {
            DataSet myDS = new DataSet();
            myDS = common.getPenaltyList(gender); 

            DataTable myDT = new DataTable();
            myDT = myDS.Tables["dataset"];

            DataView myDV = myDT.AsDataView();
            DataView datDV = myDT.AsDataView();

            if (myDS.Tables.Count != 0)
            {
                this.ddlHomePenalty.DisplayMember = "penalty";
                this.ddlHomePenalty.ValueMember = "id";
                this.ddlHomePenalty.DataSource = myDV;

                this.ddlVisitorPenalty.DisplayMember = "penalty";
                this.ddlVisitorPenalty.ValueMember = "id";
                this.ddlVisitorPenalty.DataSource = datDV;
            }
        }

        private bool validateSave()
        {
            bool bRetVal = true;
            if (btnHomePlayerNumber.Text == string.Empty && btnVisitorPlayerNumber.Text == string.Empty)
            {
                bRetVal = false;
            }
            if (ddlHomePenalty.SelectedIndex == 0 && ddlVisitorPenalty.SelectedIndex == 0)
            {
                bRetVal = false;
            }
            if (ddlHomeTime.SelectedIndex == 0 && ddlVisitorTime.SelectedIndex == 0)
            {
                bRetVal = false;
            }
            return bRetVal;
        }

        private void updateMainFormLabel(string vTeam)
        {
            //update the label on the main form with the team penalty
            string lTeamName;
            string lPlayerNum;
            Int16 i;
            if (vTeam == "home")
            {
                i = Convert.ToInt16(fc.lblHomePenalties.Text);
                i++;
                fc.lblHomePenalties.Text = Convert.ToString(i);
            }
            else
            {
                i = Convert.ToInt16(fc.lblVisitPenalties.Text);
                i++;
                fc.lblVisitPenalties.Text = Convert.ToString(i);
            }

            lTeamName = activeTeam;
            lPlayerNum = activePlayerNum;

            // update the game summary table on the main form
            addGameSummaryRow(activeTeam, "Penalty", activePlayerNum); 
        }

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

        public void addGameSummaryRow(string vTeamName, string vAction, string vPlayerNum)
        {
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            Main fc = (Main)Application.OpenForms["Main"];
            ListViewItem lvi = new ListViewItem();

            string lQuarter = "Q" + fc.lblPeriod.Text;
            string lElapsedTime = fc.lblGameTime.Text;

            lvi.Text = lQuarter;
            lvi.SubItems.Add(lElapsedTime);
            lvi.SubItems.Add(vAction);
            lvi.SubItems.Add(vTeamName);
            lvi.SubItems.Add(vPlayerNum);

            fc.lvGameSummary.Items.Insert(0, lvi);
        }

        #endregion

        #region "  REGION: PENALTY TIMER FUNCTIONS  " 

        private Timer setup_timer()
        {
            //---[ create a new timer ]---
            t = new Timer();
            fc.activePenaltyTimers++;

            //---[ set the timers interval(as this timer is designed to count seconds, this should not be changed!)
            t.Interval = 1000;

            //---[ 1st timer will have tag 1, 2nd 2,...
            t.Tag = (int)fc.listOfTimers.Count + 1;

            //---[ assign an event to the timers tick(called at the interval set above)           
            t.Tick += new EventHandler(Timers_Tick);

            return t;
        }

        private void addTimerToList(Timer t)
        {
            //---[ adding timer to list:
            ListViewItem lvi = new ListViewItem();
            lvi.Text = activeTeam;
            lvi.SubItems.Add(activePlayerNum);
            lvi.SubItems.Add(activePlayerName);
            lvi.SubItems.Add(activePenalty);

            TimeSpan ts = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
            lvi.SubItems.Add(ts.ToString("mm\\:ss"));

            fc.lvPenaltyBox.Items.Add(lvi);

        }

        private void Timers_Tick(object sender, EventArgs e)
        {
            Timer tt = sender as Timer;
            int _tag = (int)tt.Tag;

            string sSecLeft = fc.lvPenaltyBox.Items[_tag - 1].SubItems[4].Text;

            TimeSpan ts = TimeSpan.Parse(sSecLeft);
            int iSecLeft = Convert.ToInt16(Convert.ToDouble(ts.TotalSeconds / 60));

            if (iSecLeft < 1)
            {
                //stop this timer
                tt.Stop();
                tt.Dispose();
                
                //---[ notify user which timer has elapsed: ]---
                fc.activePenaltyTimers--;
            }
            else
            {
                //update the shown time 
                fc.lvPenaltyBox.Items[_tag - 1].SubItems[4].Text = getTime(tt);
            }

            if (fc.activePenaltyTimers == 0)
            {
                fc.lvPenaltyBox.Items.Clear();
                fc.listOfTimers.Clear();
            }
        }

        public string getTime(Timer tTimer)
        {
            //set and empty time variable
            int _tag = (int)tTimer.Tag;
            string sSecLeft = fc.lvPenaltyBox.Items[_tag - 1].SubItems[4].Text;

            TimeSpan ts = TimeSpan.Parse(sSecLeft);
            int iSecLeft = Convert.ToInt16(Convert.ToDouble(ts.TotalSeconds / 60));

            //---[ reduce the time remaining by a second
            iSecLeft--;

            //---[ return the time remaining
            TimeSpan tts = TimeSpan.FromSeconds(Convert.ToDouble(iSecLeft));
            return tts.ToString("mm\\:ss");
        }

        #endregion
    }
}
