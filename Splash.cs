using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml; 
using System.Windows.Forms;

namespace ScoreLaxia
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            clearGameInfoTable(); 
        }

        private void Splash_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            set_genderXML("male");
            this.Hide();
            GameSetup f = new GameSetup();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            set_genderXML("female");
            this.Hide();
            GameSetup f = new GameSetup();
            f.Show();
        }

        private void set_genderXML(string gender)
        {
            string sql = "INSERT INTO gameInfo (gender, gameID, homeTeamID, visitingTeamID) VALUES ('" + gender + "', null, null, null) ";

            App_Code.dataOperations dop = new App_Code.dataOperations();
            dop.AddUpdateRecord(sql);
        }

        private void clearGameInfoTable()
        {
            string sql = "DELETE * FROM gameInfo";
            App_Code.dataOperations dop = new App_Code.dataOperations();
            dop.AddUpdateRecord(sql);
        }

        private void btnTeamAdmin_Click(object sender, EventArgs e)
        {
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
    }
}
