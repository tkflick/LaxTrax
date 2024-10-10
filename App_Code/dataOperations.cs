using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScoreLaxia.App_Code
{
    class dataOperations
    {
        public bool AddUpdateRecord(string sSQL)
        {
            bool bSUCCESS = false;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../App_Data/LaxTrax.accdb;Persist Security Info=False;");
            OleDbCommand cmd = new OleDbCommand(sSQL);

            cmd.Connection = con;
            //cmd.Parameters.AddWithValue("@name", value); 
            con.Open();

            //cmd.ExecuteNonQuery(); 
            
            if (cmd.ExecuteNonQuery() >= 0)
            {
                bSUCCESS = true;
            }
            else
            {
                bSUCCESS = false;
            }

            con.Close();
            return bSUCCESS;
        }

        public DataSet GetDataSet(string sSQL)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../App_Data/LaxTrax.accdb;Persist Security Info=False;");
            OleDbCommand cmd = new OleDbCommand(sSQL);
            DataSet ds = new DataSet();

            cmd.Connection = con;
            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(sSQL, con);
            da.Fill(ds, "dataset");
            con.Close();

            return ds;
        }

        public string GetSingleValue(string sField, DataSet dsDataSet)
        {
	        DataView dvDataView = default(DataView);
	        string sReturn = string.Empty;

            dvDataView = new DataView(dsDataSet.Tables["dataset"]);
            foreach (DataRowView drDataRowView in dvDataView)
            {
		        sReturn = Convert.ToString(drDataRowView[sField]);
	        }

	        return (sReturn);
        }

        private void GetConnectionString(ref string _CONNECTIONSTRING, string _CONNECTION_TYPE)
        {
            switch (_CONNECTION_TYPE)
            {
                case "user_connection":
                    _CONNECTIONSTRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../App_Data/LaxTrax.accdb;Persist Security Info=False;";
                    break;
                case "rental_connection":
                    _CONNECTIONSTRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../App_Data/LaxTrax.accdb;Persist Security Info=False;";
                    break;
            }
        }

    }
}
