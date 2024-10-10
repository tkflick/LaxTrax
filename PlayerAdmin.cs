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
    public partial class PlayerAdmin : Form
    {
        App_Code.common common = new App_Code.common();
        DataSet myDS = new DataSet();
        DataSet DS = new DataSet();

        public PlayerAdmin()
        {
            InitializeComponent();
        }

        #region "  REGION: BUTTON CLICKS  " 

        private void btnChooseTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash f = new Splash();
            f.Show();
        }

        private void btnEnterNewTeam_Click(object sender, EventArgs e)
        {
            gbGender.Visible = true;
            rdoBoys.Visible = true;
            rdoBoys.Checked = false;
            rdoGirls.Visible = true;
            rdoGirls.Checked = false;
            lblPlayer.Visible = false;
            cmbPlayerList.Visible = false;
            cmbTeamList.Enabled = false;
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            lblPlayer.Visible = true;
            cmbPlayerList.Visible = true;
            gbGender.Visible = true;
            rdoBoys.Visible = true;
            rdoBoys.Checked = false;
            rdoGirls.Visible = true;
            rdoGirls.Checked = false;
            cmbTeamList.Enabled = false;
            cmbPlayerList.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lsTeamID = cmbTeamList.SelectedValue.ToString();
            string lsFName = txtFName.Text;
            string lsLName = txtLName.Text;
            string lsNumber = txtJersey.Text;
            string lsNickName = txtNickname.Text;
            string lsPosition = txtNotes.Text;
            string lsGradYear = txtGradYear.Text;
            string lsNotes = txtNotes.Text;
            string lsAwards = txtAwards.Text;
            string lsGender = "";
            if (rdoBoys.Checked == true)
            {
                lsGender = "M";
            }
            else
            {
                lsGender = "F";
            }
            
            // add new player
            if (common.addNewPlayer(lsTeamID,lsNumber, lsFName, lsLName, lsNickName, lsGender, lsPosition, string.Empty, lsGradYear, string.Empty, lsNotes, lsAwards ))
            {
                cmbTeamList.SelectedIndex = 0;
                txtFName.Text = string.Empty;
                txtLName.Text = string.Empty;
                txtJersey.Text = string.Empty;
                txtNickname.Text = string.Empty;
                txtNotes.Text = string.Empty;
                txtGradYear.Text = string.Empty;
                txtNotes.Text = string.Empty;
                txtAwards.Text = string.Empty;
            }
            else
            {
                //bad 
            }
        }

        #endregion

        #region "  REGION: CONTROL EVENTS  "

        private void rdoBoys_CheckedChanged(object sender, EventArgs e)
        {
            cmbTeamList.Enabled = true;
            cmbPlayerList.Enabled = true;
            popTeams("male"); 
        }

        private void rdoGirls_CheckedChanged(object sender, EventArgs e)
        {
            cmbTeamList.Enabled = true;
            cmbPlayerList.Enabled = true;
            popTeams("female"); 
        }

        private void cmbTeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get player list and populate the playerlist combo box
            string lsTeamID = cmbTeamList.SelectedValue.ToString();
            getPlayerList(lsTeamID); 
        }

        private void cmbPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get players details and populate the form. 
            string lsPlayerID = cmbPlayerList.SelectedValue.ToString();
            getPlayerDetail(lsPlayerID); 
        }

        #endregion

        #region "  REGION: HELPER FUNCTIONS  " 

        private void popTeams(string vsGender) 
        {
            string sql = "SELECT * FROM teams WHERE gender = '" + vsGender + "'";
            App_Code.dataOperations dop = new App_Code.dataOperations();

            myDS = dop.GetDataSet(sql);

            DataTable myDT = new DataTable();
            myDT = myDS.Tables["dataset"];

            //insert the header row into the datatable
            DataRow myDR = myDT.NewRow();
            myDR[0] = "00";
            myDR[1] = "Select a Team";
            myDR[2] = "";
            myDR[3] = "";
            myDT.Rows.InsertAt(myDR, 0);

            DataView myDV = myDT.AsDataView();

            if (myDS.Tables.Count != 0)
            {
                cmbTeamList.DisplayMember = "teamName";
                cmbTeamList.ValueMember = "teamID";
                cmbTeamList.DataSource = myDV;
            }
        }

        private void getPlayerList(string vsTeamID)
        {
            string sql2 = "SELECT playerID, [first_name] & ' ' & [last_name] as playerName FROM roster WHERE teamID = " + vsTeamID;
            App_Code.dataOperations dop = new App_Code.dataOperations();

            DS = dop.GetDataSet(sql2);

            DataTable DT = new DataTable();
            DT = DS.Tables["dataset"];

            //insert the header row into the datatable
            DataRow DR = DT.NewRow();
            DR[0] = "00";
            DR[1] = "Select a Player";

            DT.Rows.InsertAt(DR, 0);
             
            DataView DV = DT.AsDataView();

            if (DS.Tables.Count != 0)
            {
                cmbPlayerList.DisplayMember = "playerName";
                cmbPlayerList.ValueMember = "playerID";
                cmbPlayerList.DataSource = DV;
            }
        }

        private void getPlayerDetail(string vsPlayerID)
        {
            string sql = "SELECT * FROM roster WHERE playerID = " + vsPlayerID;
            App_Code.dataOperations dop = new App_Code.dataOperations();
            DataSet oDS = new DataSet(); 

            oDS = dop.GetDataSet(sql);
            txtFName.Text = dop.GetSingleValue("first_name", oDS);
            txtLName.Text = dop.GetSingleValue("last_name", oDS);
            txtJersey.Text = dop.GetSingleValue("jersey_number", oDS);
            txtNickname.Text = dop.GetSingleValue("nickname", oDS);
            txtPosition.Text = dop.GetSingleValue("position", oDS);
            txtGradYear.Text = dop.GetSingleValue("graduation_year", oDS);
            txtNotes.Text = dop.GetSingleValue("notes", oDS);
            txtAwards.Text = dop.GetSingleValue("awards", oDS);

        }

        #endregion

    }
}
