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
    public partial class goalieSetup : Form
    {
        private string homeTeam;
        private string visitingTeam;
        private string gender;
        
        public goalieSetup()
        {
            InitializeComponent();

            getTeamNames();
            getGender();

        }

        #region " REGION: BUTTON CLICKS " 

        private void btnHomeNumber_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            btnHomeNumber.Text = userEnteredText;

            popup.Dispose();
        }

        private void btnVisitorNumber_Click(object sender, EventArgs e)
        {
            numpad popup = new numpad();
            //show the numberpad
            popup.ShowDialog();
            //get the number entered
            string userEnteredText = popup.EnteredText;
            btnVisitorNumber.Text = userEnteredText;

            popup.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save home team goalie
            if (btnHomeNumber.Text != "Goalie #")
            {
                //string homeGoalieID = getPlayerID(homeTeam, getPlayerName(lblHomeTeam.Text, btnHomeNumber.Text));
                saveGoalie(btnHomeNumber.Text, "homeGoalieID");
            }
            
            //save visiting team goalie
            if (btnVisitorNumber.Text != "Goalie #")
            {
                //string visitorGoalieID = getPlayerID(visitingTeam, getPlayerName(lblVisitingTeam.Text, btnVisitorNumber.Text));
                saveGoalie(btnVisitorNumber.Text, "visitingGoalieID");
            }
            this.Hide();
        }

        #endregion

        #region " REGION: HELPER FUNCTIONS "
        
        private void getTeamNames()
        {
            string sql = "SELECT teamName as HomeTeam, (SELECT teamName as VisitingTeam FROM teams WHERE teamID = (SELECT visitingTeamID FROM gameInfo)) as VisitingTeam FROM gameInfo gi, teams t WHERE t.teamID = (SELECT homeTeamID FROM gameInfo)";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            homeTeam = dop.GetSingleValue("HomeTeam", ds);
            visitingTeam = dop.GetSingleValue("VisitingTeam", ds);

            lblHomeTeam.Text = homeTeam + " Goalie";
            lblVisitingTeam.Text = visitingTeam + " Goalie";


        }

        private void getGender()
        {
            string sql = "SELECT gender FROM gameInfo";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            gender = dop.GetSingleValue("gender", ds);
        }

        private void saveGoalie(string vPlayerID, string vTeamType)
        {
            //save the ID of the current goalie 
            string sql = "UPDATE gameInfo SET " + vTeamType + " = " + vPlayerID;
            App_Code.dataOperations dop = new App_Code.dataOperations();
            dop.AddUpdateRecord(sql); 
        }

        private string getPlayerID(string vTeamID, string playerName)
        {
            string lRetVal = string.Empty;
            string sql = "SELECT * FROM roster WHERE teamID = " + vTeamID + " AND last_name = '" + playerName + "';";
            DataSet ds = new DataSet();
            App_Code.dataOperations dop = new App_Code.dataOperations();

            ds = dop.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                lRetVal = dop.GetSingleValue("playerID", ds);
            }
            else
            {
                MessageBox.Show("Player not found!", "Error", MessageBoxButtons.OK);
            }

            return lRetVal;
        }

        private string getPlayerName(string teamName, string number)
        {
            string sql = "SELECT last_name FROM roster WHERE teamID = (SELECT teamID FROM teams WHERE teamName = '" + teamName + "') and jersey_number = " + number;
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            string playerName = dop.GetSingleValue("last_name", ds);
             
            return playerName;
        }

        #endregion

    }
}
