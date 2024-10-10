using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace ScoreLaxia.App_Code
{
    class common
    {
        App_Code.dataOperations dop = new App_Code.dataOperations();
        DataSet ds = new DataSet();

        #region " REGION: ADD / EDIT TEAM AND PLAYER INFO " 

        public bool addNewTeam(string vTeamName, string vMascot, string vGender)
        {
            bool bRetVal = false;
            string sql = "INSERT INTO teams (teamName, mascot, gender) VALUES ('" + vTeamName + "','" + vMascot + "','" + vGender + "')";

            bRetVal = dop.AddUpdateRecord(sql); 
            
            return bRetVal;
        }

        public bool editTeam(string vTeamID, string vTeamName, string vMascot, string vGender)
        {
            bool bRetVal = false;
            string sql = "UPDATE teams SET teamName = '" + vTeamName + "', mascot = '" + vMascot + "', gender = '" + vGender + "' WHERE teamID = " + vTeamID;

            bRetVal = dop.AddUpdateRecord(sql);

            return bRetVal;
        }

        public bool addNewPlayer(string vTeamID, string vNumber, string vFName, string vLName, string vNickName, string vGender, string vPosition, string vDOB, string vGradYear, string vFileName, string vNotes, string vAwards)
        {
            bool bRetVal = false;

            string sql = "INSERT INTO roster (teamID, jersey_number, first_name, last_name, nickname, gender, position, dob, graduation_year, photo_filename, notes, awards) ";
            sql += "VALUES (" + vTeamID + "," + vNumber + ",'" + vFName + "','" + vLName  + "','" + vNickName + "','" + vGender + "','" + vPosition + "','" + vDOB + "','" + vGradYear + "','" + vFileName  + "','" + vNotes  + "','" + vAwards  + "')";

            bRetVal = dop.AddUpdateRecord(sql); 
            return bRetVal;
        }
         
        public bool editPlayer(string vPlayerID, string vTeamID, string vNumber, string vFName, string vLName, string vNickName, string vGender, string vPosition, string vDOB, string vGradYear, string vFileName, string vNotes, string vAwards)
        {
            bool bRetVal = false;

            string sql = "UPDATE roster SET teamID = " + vTeamID + ", jersey_number = " + vNumber + ", first_name = '" + vFName + "', last_name = '" + vLName + "', nickname = '" + vNickName + "', gender = '" + vGender + "', position = '" + vPosition + "', dob = '" + vDOB + "', graduation_year = '" + vGradYear + "', photo_filename = '" + vFileName + "', notes = '" + vNotes + "', awards = '" + vAwards + "' ";
            sql += "WHERE playerID = " + vPlayerID;

            bRetVal = dop.AddUpdateRecord(sql); 
            return bRetVal;
        }

        #endregion

        public void getTeamNames(ref string homeTeam, ref string visitingTeam)
        {
            string sql = "SELECT teamName as HomeTeam, (SELECT teamName as VisitingTeam FROM teams WHERE teamID = (SELECT visitingTeamID FROM gameInfo)) as VisitingTeam FROM gameInfo gi, teams t WHERE t.teamID = (SELECT homeTeamID FROM gameInfo)";
            ds = dop.GetDataSet(sql);
            homeTeam = dop.GetSingleValue("HomeTeam", ds);
            visitingTeam = dop.GetSingleValue("VisitingTeam", ds);
        }

        public void getGender(ref string gender)
        {
            string sql = "SELECT gender FROM gameInfo";
            ds = dop.GetDataSet(sql);
            gender = dop.GetSingleValue("gender", ds);
        }

        public string getGender()
        {
            string sql = "SELECT gender FROM gameInfo";
            ds = dop.GetDataSet(sql);
            string gender = dop.GetSingleValue("gender", ds);
            return gender;
        }

        public string getGameInfo(string vTeamName, string vGender, string vField)
        {
            string lRetVal = string.Empty;
            string sql = "SELECT * FROM gameInfo";
            DataSet ds = new DataSet();

            ds = dop.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                lRetVal = dop.GetSingleValue(vField, ds);
            }
            else
            {
                //MessageBox.Show("Player not found!", "Error", MessageBoxButtons.OK);
                lRetVal = "!!";
            }

            return lRetVal;
        }

        public string getPlayerID(string vTeamID, string playerName)
        {
            string lRetVal = string.Empty;
            string sql = "SELECT * FROM roster WHERE teamID = " + vTeamID + " AND last_name = '" + playerName + "';";
            DataSet ds = new DataSet();

            ds = dop.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                lRetVal = dop.GetSingleValue("playerID", ds);
            }
            else
            {
                //MessageBox.Show("Player not found!", "Error", MessageBoxButtons.OK);
            }

            return lRetVal;
        }

        public int get_maxGameID()
        {
            string sql = "SELECT max(gameID) as gameID FROM stats";

            DataSet myDS = new DataSet();
            myDS = dop.GetDataSet(sql);
            string i = dop.GetSingleValue("gameID", myDS);

            return Convert.ToInt16(i);
        }

        public bool checkGoalieSetup()
        {
            bool bRetVal = false;
            string sql = "SELECT * FROM gameInfo WHERE homeGoalieID IS NOT NULL AND visitingGoalieID IS NOT NULL";
            DataSet ds = new DataSet();

            ds = dop.GetDataSet(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                bRetVal = true;
            }
            else
            {
                //MessageBox.Show("Player not found!", "Error", MessageBoxButtons.OK);
                bRetVal = false;
            }


            return bRetVal; 
        }

        public string getPlayerName(string teamName, string number)
        { 
            string sql = "SELECT last_name FROM roster WHERE teamID = (SELECT teamID FROM teams WHERE teamName = '" + teamName + "') and jersey_number = " + number;
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            string playerName = dop.GetSingleValue("last_name", ds);

            return playerName;
        }

        public DataSet getPenaltyList(string gender)
        { 
            string sql = "SELECT id, penalty FROM ref_penalties WHERE gender = '" + gender + "' ORDER BY penalty ";
            DataSet ds = new DataSet();
            ds = dop.GetDataSet(sql);
            return ds;
        }

        #region " REGION:  DATABASE UPDATES  " 

        public void set_gameID(string game_id)
        {
            string sql = "UPDATE gameInfo SET gameID = '" + game_id + "'";
            dop.AddUpdateRecord(sql);
        }

        public void set_Game(string home_team, string visiting_team, string half_length, string running_time)
        {
            string sql = "UPDATE gameInfo SET homeTeamID = '" + home_team + "', visitingTeamID = '" + visiting_team + "', lengthOfHalf = '" + half_length + "', runningTime = '" + running_time + "'";
            dop.AddUpdateRecord(sql);
        }


        #endregion

    }
}
