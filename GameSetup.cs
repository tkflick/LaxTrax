using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace ScoreLaxia
{
    public partial class GameSetup : Form
    {
        App_Code.common common = new App_Code.common();

        public GameSetup()
        {
            InitializeComponent();
            //get the gender of the upcoming game and use it to pull the correct teams
            populateDropdowns(common.getGender());
        }

        #region " REGION: BUTTON CLICKS " 

        /// <summary>
        /// Chose Teams button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            pbLogo.Visible = false;
            pnlChooseTeams.Visible = true;
        }

        /// <summary>
        /// Start Game button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            string rErrDesc = string.Empty;
            string lRunningTime = "N";
            if (validateStart(ref rErrDesc))
            { 
                //get the current max game id
                int i = common.get_maxGameID();
                //increment the game id by 1
                i++;
                //save the new game id to the gameType xml
                common.set_gameID(i.ToString());
                                
                if (rdoRunningClock1.Checked)
                {
                    lRunningTime = "Y";
                }
                if (rdoRunningClock2.Checked)
                {
                    lRunningTime = "N";
                }
                common.set_Game(ddlHomeTeam.SelectedValue.ToString(), ddlVisitor.SelectedValue.ToString(), txtHalfLength.Text, lRunningTime);

                //show the main game scoring form 
                this.Hide();
                Main f = new Main();
                f.Show();
            }
            else
            {
                MessageBox.Show(rErrDesc, "Error", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region " REGION: HELPER FUNCTIONS " 
        
        private void populateDropdowns(string gender)
        {
            string sql = "SELECT * FROM teams WHERE gender = '" + gender + "'";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            
            DataSet myDS = new DataSet();
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
            DataView datDV = myDT.AsDataView(); 

            if (myDS.Tables.Count != 0) 
            {
                this.ddlHomeTeam.DisplayMember = "teamName";
                this.ddlHomeTeam.ValueMember = "teamID";
                this.ddlHomeTeam.DataSource = myDV;

                this.ddlVisitor.DisplayMember = "teamName";
                this.ddlVisitor.ValueMember = "teamID";
                this.ddlVisitor.DataSource = datDV;
            }
        }

        public bool validateStart(ref string rErrDesc)
        {
            bool bRetVal = true;
            if (ddlHomeTeam.SelectedIndex == 0)
            {
                bRetVal = false;
                rErrDesc = "Home Team Not Selected";
            }
            if (ddlVisitor.SelectedIndex == 0)
            {
                bRetVal = false;
                rErrDesc = "Visiting Team Not Selected";
            }
            if (txtHalfLength.Text.Trim() == "")
            {
                bRetVal = false;
                rErrDesc = "Length of Halves Not Specified";
            }
            if (!rdoRunningClock1.Checked && !rdoRunningClock2.Checked)
            {
                bRetVal = false;
                rErrDesc = "Running Clock Not Specified";
            }

            return bRetVal;
        }

        #endregion

        private void btnTeamAdmin_Click(object sender, EventArgs e)
        {
            //show the main game scoring form 
            this.Hide();
            AddNewTeam f = new AddNewTeam();
            f.Show();
        }

        private void btnPlayerAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerAdmin f = new PlayerAdmin();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash f = new Splash();
            f.Show();
        }

    }
}
