using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScoreLaxia.App_Code
{
    class logStats
    {
        public bool logPlayerStat(string vField, string vGameID, string vTeamID, string vPlayerID)
        {
            bool lRetVal = false;
            string sql = string.Empty; 

            dataOperations dop = new dataOperations();
            DataSet ds = new DataSet();

            try
            {
                //first check that the player has a db entry in the stats table for this game
                sql = "SELECT * FROM stats WHERE gameID = " + vGameID + " AND teamID = " + vTeamID + " AND playerID = " + vPlayerID;
                ds = dop.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //if not, we have to to an insert
                    sql = "INSERT INTO stats (gameID, teamID, playerID, " + vField + ") VALUES (" + vGameID + ", " + vTeamID + ", " + vPlayerID + ", 1)";
                }
                else
                {
                    //otherwise we do an update 
                    sql = "UPDATE stats SET " + vField + " = " + vField + " + 1 WHERE gameID = " + vGameID + " AND teamID = " + vTeamID + " AND playerID = " + vPlayerID;
                }
                dop.AddUpdateRecord(sql);
                lRetVal = true;

                return lRetVal; 
            }
            catch 
            {
                return lRetVal; 
            }            
        }
    }
}
