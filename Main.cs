using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScoreLaxia
{
    public partial class Main : Form
    {
        public int period = 1;
        public int maxPeriods = 2;
        public int activePenaltyTimers = 0;
        public List<Timer> listOfTimers;

        //variables to hold the minutes/seconds for the Main timer
        public int iMinutes = 25; 
        public int seconds; 
        public Timer timer;
        
        static Main _frmObj;
        public static Main frmObj
        {
            get { return _frmObj; }
            set { _frmObj = value; }
        }
         
        public Main() 
        {
            InitializeComponent();
            
            frmObj = this;
            listOfTimers = new List<Timer>();
            lblPeriod.Text = period.ToString(); 
            seconds = iMinutes * 60;

            //get the gender from the GameType XML, then set the app to the correct gender style
            setAppForGender(get_gender());
            setTeamNames(); 

            //create a timer
            setup_timer(); 

            TimeSpan ts = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
            lblGameTime.Text = ts.ToString("mm\\:ss");

            //creating listView for list game penalties:
            lvPenaltyBox.Columns.Add("Team", 100, HorizontalAlignment.Left);
            lvPenaltyBox.Columns.Add("#", 40, HorizontalAlignment.Left);
            lvPenaltyBox.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
            lvPenaltyBox.Columns.Add("Offense", 100, HorizontalAlignment.Center);
            lvPenaltyBox.Columns.Add("Time", 60, HorizontalAlignment.Center);
            lvPenaltyBox.View = View.Details;

            // create listview for game summary updates
            // Quarter / Time Elapsed / Action / Team Abbreviation / Player #
            lvGameSummary.Columns.Add("Quarter", 50, HorizontalAlignment.Left);
            lvGameSummary.Columns.Add("Time Elapsed", 85, HorizontalAlignment.Left);
            lvGameSummary.Columns.Add("Action", 100, HorizontalAlignment.Left);
            lvGameSummary.Columns.Add("Team", 100, HorizontalAlignment.Center);
            lvGameSummary.Columns.Add("Player #", 60, HorizontalAlignment.Center);
            lvGameSummary.View = View.Details;

        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                string lex = ex.Message;
            }
        }

        #region " REGION: HELPER FUNCTIONS " 

        private void setAppForGender(string gender)
        {
            // do some stuff 
            Color backColor; 
            if (gender == "female") 
            { 
                backColor = Color.Orchid; 
            } else {
                backColor = Color.LightSteelBlue;
            }
            lblHomeScore.BackColor = backColor;
            lblVisitorScore.BackColor = backColor;
        }

        private void setTeamNames()
        {
            string sql = "SELECT teamName as HomeTeam, (SELECT teamName as VisitingTeam FROM teams WHERE teamID = (SELECT visitingTeamID FROM gameInfo)) as VisitingTeam FROM gameInfo gi, teams t WHERE t.teamID = (SELECT homeTeamID FROM gameInfo)";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            string lstrHomeTeam = dop.GetSingleValue("HomeTeam", ds);
            string lstrVisitingTeam = dop.GetSingleValue("VisitingTeam", ds);

            lblHomeTeam.Text = lstrHomeTeam;
            lblVistorTeam.Text = lstrVisitingTeam;

        }

        #endregion 
        
        #region " REGION: BUTTON CLICKS "

        private void btnFaceoff_Click(object sender, EventArgs e)
        {
            //check for goalie set up first 
            App_Code.common common = new App_Code.common();
            if (!common.checkGoalieSetup())
            {
                MessageBox.Show("Goalies Not Selected!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                faceoff popup = new faceoff();
                popup.ShowDialog();

                string userEnteredText = popup.EnteredText;
                popup.Dispose();
            }
        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            frmShot popup = new frmShot();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnGoalieSetup_Click(object sender, EventArgs e)
        {
            goalieSetup popup = new goalieSetup();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnGroundball_Click(object sender, EventArgs e)
        {
            Groundball popup = new Groundball();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            //check the score, if the lead is 10 or more, stop the clock
            Main fc = (Main)Application.OpenForms["Main"];
            Int16 iHomeScore = Convert.ToInt16(fc.lblHomeScore.Text);
            Int16 iVisitorScore = Convert.ToInt16(fc.lblVisitorScore.Text);
            Int16 iLead;
            if (iHomeScore > iVisitorScore)
            {
                iLead = Convert.ToInt16(iHomeScore - iVisitorScore);
            }
            else
            {
                iLead = Convert.ToInt16(iVisitorScore - iHomeScore);
            }
            if (iLead < 10)
            {
                //stop the timer
                timer.Stop();
                //also, stop any penalty timers still going 
                stopAllPenaltyTimers(); 
                //enable the start button
                pbTimerStart.Enabled = true;
                //disable the stop button
                pbTimerStop.Enabled = false;
            }
            
            goal popup = new goal();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmShot popup = new frmShot();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnFTurnover_Click(object sender, EventArgs e)
        {
            forcedTurnover popup = new forcedTurnover();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnTurnover_Click(object sender, EventArgs e)
        {
            turnover popup = new turnover();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            teamClearSuccess popup = new teamClearSuccess();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnFClear_Click(object sender, EventArgs e)
        {
            teamClearFail popup = new teamClearFail();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnFOViolations_Click(object sender, EventArgs e)
        {
            //stop the timer
            timer.Stop();
            //also, stop any penalty timers still going 
            stopAllPenaltyTimers();
            //enable the start button
            pbTimerStart.Enabled = true;
            //disable the stop button
            pbTimerStop.Enabled = false;

            foViolation popup = new foViolation();
            popup.ShowDialog();

            popup.Dispose();
        }

        private void btnPenalty_Click(object sender, EventArgs e)
        {
            //stop the timer
            timer.Stop();
            //also, stop any penalty timers still going 
            stopAllPenaltyTimers();
            //enable the start button
            pbTimerStart.Enabled = true;
            //disable the stop button
            pbTimerStop.Enabled = false;

            penalty popup = new penalty();
            popup.ShowDialog();

            popup.Dispose();
        }

        #endregion

        #region " REGION: DATA FUNCTIONS "

        private string get_gender()
        {
            string sql = "SELECT gender FROM gameInfo ";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            string lstrGender = dop.GetSingleValue("gender", ds);

            return lstrGender;
        }

        #endregion

        #region " REGION: GAME TIME TIMER FUNCTIONS "

        private void setup_timer()
        {
            //create a timer 
            timer = new Timer();
            //set the timers interval(as this timer is designed to count seconds, this should not be changed!)
            timer.Interval = 1000;
            //assign an event to the timers tick(called at the interval set above)
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void pbTimerStart_Click(object sender, EventArgs e)
        {
            //start the timer
            timer.Start();
            //disable the start button
            pbTimerStart.Enabled = false; 
            //enable the stop button
            pbTimerStop.Enabled = true;
            //need to restart any penalty timers not expired
            startAllPenaltyTimers();
        }

        private void pbTimerStop_Click(object sender, EventArgs e)
        {
            //stop the timer
            timer.Stop();
            //enable the start button
            pbTimerStart.Enabled = true;
            //disable the stop button
            pbTimerStop.Enabled = false;
            //also need to stop all the penalty timers
            stopAllPenaltyTimers(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset time display
            reset_timer();
        }

        /// <summary>
        /// Called whenever the timer "ticks"
        /// as defined by the interval value set
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            //calls the getTime function and sets the labels value for display
            lblGameTime.Text = getTime();
            if (lblGameTime.Text == String.Empty)
            {
                if (lblPeriod.Text == "1")
                {
                    reset_timer();
                    
                    //stop all penalty timers.. we'll restart them in the second half
                    stopAllPenaltyTimers(); 

                    int currentPeriod = Convert.ToInt16(lblPeriod.Text) + 1;
                    if (currentPeriod.ToString() == maxPeriods.ToString())
                    {
                        lblPeriod.Text = currentPeriod.ToString();
                    }
                }
                else
                {
                    lblGameTime.Text = "FINAL";
                    btnReset.Enabled = false;
                    pbTimerStop.Enabled = false;
                    pbTimerStart.Enabled = false;
                }                
            }
        }

        /// <summary>
        /// Called when I need to reset the timer display 
        /// back to the default value
        /// </summary>
        private void reset_timer()
        {
            //stop the timer
            timer.Stop();

            //reset time display
            seconds = iMinutes * 60;
            TimeSpan ts = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
            lblGameTime.Text = ts.ToString("mm\\:ss");
            pbTimerStart.Enabled = true;
            pbTimerStop.Enabled = false; 
        }

        /// <summary>
        /// Checks the amount of time remaining
        /// If time is expired will attempt to play a sound and prompt the user that time has extended
        /// </summary>
        /// <returns>The formatted time remaining[FORMAT -> hh:mm:ss]</returns>
        public string getTime()
        {
            //set and empty time variable
            string time = "";
            //reduce the time remaining by a second
            seconds--;

            //check if time remaining
            if (seconds == 0)
            {
                //time has expired
                timer.Stop();
               
                try
                {
                    //Create a directory info variable, used to get a count of the number of sound files available
                    //System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath + @"\sounds\");

                    //get the number of files in the directory
                    //fileCount = dir.GetFiles().Length;

                    //load the sound file
                    //SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\sounds\" + (theRndNum.Next(fileCount) + 1) + ".wav");

                    //play the sound
                    //simpleSound.Play();
                }

                //catch any generated errors

                catch (System.IO.DirectoryNotFoundException)
                {
                    //directory does not exist
                    MessageBox.Show("The directory:" + System.Environment.NewLine + Application.StartupPath + @"\sounds\" + System.Environment.NewLine + System.Environment.NewLine + "Could not be found!" + System.Environment.NewLine + "Please create the directory and add your sound files here");
                }
                catch (Exception ex)
                {
                    //let the user know there was an error
                    MessageBox.Show("There was an error!" + System.Environment.NewLine + ex);
                }
                finally
                {
                    //reset time display
                    reset_timer();
                }
            }
            else
            {
                //time is still remaining

                //create a timespan object to format the time from the seconds remaining
                TimeSpan ts = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
                //format the seconds remaining
                time = ts.ToString("mm\\:ss");
            }
            //return the time remaining
            return time;
        }

        #endregion

        #region " REGION: PENALTY TIMER HANDLER FUNCTIONS "

        public void stopAllPenaltyTimers()
        {
            foreach (System.Windows.Forms.Timer i in listOfTimers)
            {
                i.Stop();
            }
        }

        public void startAllPenaltyTimers()
        { 
            foreach (System.Windows.Forms.Timer i in listOfTimers)
            {
                i.Start();
            }
        }

        #endregion
    }

}
