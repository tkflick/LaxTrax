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
    public partial class AddNewTeam : Form
    {
        App_Code.common common = new App_Code.common();
        DataSet myDS = new DataSet();

        public AddNewTeam()
        {
            InitializeComponent();
            popGender();
        }

        #region "  REGION: BUTTON CLICKS " 

        private void btnStart_Click(object sender, EventArgs e)
        {
            string ls_TeamID;
            string ls_TeamName = txtTeamName.Text;
            string ls_Mascot = txtMascot.Text;
            string ls_Gender = cmbGender.SelectedValue.ToString();

            if (btnStart.Text == "Update Team Info")
            {
                ls_TeamName = cmbTeamNames.Text;
                ls_TeamID = cmbTeamNames.SelectedValue.ToString();
                if (common.editTeam(ls_TeamID, ls_TeamName, ls_Mascot, ls_Gender))
                {
                    //good
                    cmbTeamNames.SelectedIndex = 0;
                    txtMascot.Text = string.Empty;
                    cmbGender.SelectedIndex = 0;
                }
                else 
                {
                    //bad
                }
            }
            else
            {
                // add new team
                if (common.addNewTeam(ls_TeamName, ls_Mascot, ls_Gender))
                {
                    //good
                    txtTeamName.Text = string.Empty;
                    txtMascot.Text = string.Empty;
                    cmbGender.SelectedIndex = 0;
                }
                else
                {
                    //bad 
                }
            }
        }

        private void btnEnterNewTeam_Click(object sender, EventArgs e)
        {
            lblActionHeader.Text = "- Add New Team";
            btnStart.Text = "Save New Team";
            cmbTeamNames.Visible = false;
            txtTeamName.Visible = true;
            gbGender.Visible = false;
            rdoBoys.Visible = false;
            rdoGirls.Visible = false;
            rdoBoys.Checked = false;
            rdoGirls.Checked = false;
        }
        
        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            lblActionHeader.Text = "- Edit Existing Team";
            btnStart.Text = "Update Team Info";
            cmbTeamNames.Visible = true;
            cmbTeamNames.Enabled = false;
            txtTeamName.Visible = false;
            gbGender.Visible = true;
            rdoBoys.Visible = true;
            rdoBoys.Checked = false;
            rdoGirls.Visible = true;
            rdoGirls.Checked = false;
        }

        private void btnChooseTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash f = new Splash();
            f.Show();
        }

        #endregion 

        #region "  REGION:  CONTROL EVENTS  "

        private void rdoBoys_CheckedChanged(object sender, EventArgs e)
        {
            popTeams("male");
            cmbTeamNames.Enabled = true;
        }

        private void rdoGirls_CheckedChanged(object sender, EventArgs e)
        {
            popTeams("female");
            cmbTeamNames.Enabled = true;
        }
        
        private void cmbTeamNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //populate the data on the form
        }

        #endregion 

        #region "  REGION: HELPER FUNCTIONS  "

        private void popGender()
        {
            cmbGender.DisplayMember = "Text";
            cmbGender.ValueMember = "Value";

            var items = new[] 
            { 
                new { Text = "Select Gender..", Value = "" }, 
                new { Text = "Boys", Value = "male" }, 
                new { Text = "Girls", Value = "female" }
            };
            cmbGender.DataSource = items;
        }

        private void popTeams(string vGender)
        {
            string sql = "SELECT * FROM teams WHERE gender = '" + vGender + "'";
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
                cmbTeamNames.DisplayMember = "teamName";
                cmbTeamNames.ValueMember = "teamID";
                cmbTeamNames.DataSource = myDV;
            }
        }

        #endregion
    }
}
