namespace ScoreLaxia
{
    partial class PlayerAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdoGirls = new System.Windows.Forms.RadioButton();
            this.rdoBoys = new System.Windows.Forms.RadioButton();
            this.pnlNewTeam = new System.Windows.Forms.Panel();
            this.cmbPlayerList = new System.Windows.Forms.ComboBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtAwards = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGradYear = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJersey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTeamList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseTeams = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnEnterNewTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            this.pnlNewTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdoGirls);
            this.gbGender.Controls.Add(this.rdoBoys);
            this.gbGender.Location = new System.Drawing.Point(24, 244);
            this.gbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGender.Size = new System.Drawing.Size(147, 123);
            this.gbGender.TabIndex = 23;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Select Gender";
            // 
            // rdoGirls
            // 
            this.rdoGirls.AutoSize = true;
            this.rdoGirls.Location = new System.Drawing.Point(32, 60);
            this.rdoGirls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoGirls.Name = "rdoGirls";
            this.rdoGirls.Size = new System.Drawing.Size(140, 26);
            this.rdoGirls.TabIndex = 18;
            this.rdoGirls.TabStop = true;
            this.rdoGirls.Text = "Girls Teams";
            this.rdoGirls.UseVisualStyleBackColor = true;
            this.rdoGirls.CheckedChanged += new System.EventHandler(this.rdoGirls_CheckedChanged);
            // 
            // rdoBoys
            // 
            this.rdoBoys.AutoSize = true;
            this.rdoBoys.Location = new System.Drawing.Point(32, 32);
            this.rdoBoys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBoys.Name = "rdoBoys";
            this.rdoBoys.Size = new System.Drawing.Size(143, 26);
            this.rdoBoys.TabIndex = 17;
            this.rdoBoys.TabStop = true;
            this.rdoBoys.Text = "Boys Teams";
            this.rdoBoys.UseVisualStyleBackColor = true;
            this.rdoBoys.CheckedChanged += new System.EventHandler(this.rdoBoys_CheckedChanged);
            // 
            // pnlNewTeam
            // 
            this.pnlNewTeam.Controls.Add(this.cmbPlayerList);
            this.pnlNewTeam.Controls.Add(this.lblPlayer);
            this.pnlNewTeam.Controls.Add(this.txtAwards);
            this.pnlNewTeam.Controls.Add(this.label10);
            this.pnlNewTeam.Controls.Add(this.txtNotes);
            this.pnlNewTeam.Controls.Add(this.label9);
            this.pnlNewTeam.Controls.Add(this.txtGradYear);
            this.pnlNewTeam.Controls.Add(this.txtPosition);
            this.pnlNewTeam.Controls.Add(this.label8);
            this.pnlNewTeam.Controls.Add(this.txtJersey);
            this.pnlNewTeam.Controls.Add(this.label7);
            this.pnlNewTeam.Controls.Add(this.cmbTeamList);
            this.pnlNewTeam.Controls.Add(this.label6);
            this.pnlNewTeam.Controls.Add(this.txtLName);
            this.pnlNewTeam.Controls.Add(this.label5);
            this.pnlNewTeam.Controls.Add(this.txtNickname);
            this.pnlNewTeam.Controls.Add(this.txtFName);
            this.pnlNewTeam.Controls.Add(this.label4);
            this.pnlNewTeam.Controls.Add(this.label3);
            this.pnlNewTeam.Controls.Add(this.btnSave);
            this.pnlNewTeam.Controls.Add(this.label2);
            this.pnlNewTeam.Location = new System.Drawing.Point(201, 128);
            this.pnlNewTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNewTeam.Name = "pnlNewTeam";
            this.pnlNewTeam.Size = new System.Drawing.Size(600, 398);
            this.pnlNewTeam.TabIndex = 22;
            // 
            // cmbPlayerList
            // 
            this.cmbPlayerList.Enabled = false;
            this.cmbPlayerList.FormattingEnabled = true;
            this.cmbPlayerList.Location = new System.Drawing.Point(444, 15);
            this.cmbPlayerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPlayerList.Name = "cmbPlayerList";
            this.cmbPlayerList.Size = new System.Drawing.Size(132, 24);
            this.cmbPlayerList.TabIndex = 26;
            this.cmbPlayerList.Visible = false;
            this.cmbPlayerList.SelectedIndexChanged += new System.EventHandler(this.cmbPlayerList_SelectedIndexChanged);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(347, 15);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(81, 24);
            this.lblPlayer.TabIndex = 25;
            this.lblPlayer.Text = "Player:";
            this.lblPlayer.Visible = false;
            // 
            // txtAwards
            // 
            this.txtAwards.Location = new System.Drawing.Point(156, 245);
            this.txtAwards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAwards.Multiline = true;
            this.txtAwards.Name = "txtAwards";
            this.txtAwards.Size = new System.Drawing.Size(412, 61);
            this.txtAwards.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Awards:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(156, 175);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(412, 61);
            this.txtNotes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Notes:";
            // 
            // txtGradYear
            // 
            this.txtGradYear.Location = new System.Drawing.Point(156, 143);
            this.txtGradYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradYear.Name = "txtGradYear";
            this.txtGradYear.Size = new System.Drawing.Size(177, 22);
            this.txtGradYear.TabIndex = 7;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(460, 112);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(112, 22);
            this.txtPosition.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Position:";
            // 
            // txtJersey
            // 
            this.txtJersey.Location = new System.Drawing.Point(460, 79);
            this.txtJersey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJersey.Name = "txtJersey";
            this.txtJersey.Size = new System.Drawing.Size(53, 22);
            this.txtJersey.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jersey #:";
            // 
            // cmbTeamList
            // 
            this.cmbTeamList.Enabled = false;
            this.cmbTeamList.FormattingEnabled = true;
            this.cmbTeamList.Location = new System.Drawing.Point(156, 12);
            this.cmbTeamList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTeamList.Name = "cmbTeamList";
            this.cmbTeamList.Size = new System.Drawing.Size(177, 24);
            this.cmbTeamList.TabIndex = 1;
            this.cmbTeamList.SelectedIndexChanged += new System.EventHandler(this.cmbTeamList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Team Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(156, 80);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(177, 22);
            this.txtLName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Name:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(156, 111);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(177, 22);
            this.txtNickname.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(156, 47);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(177, 22);
            this.txtFName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grad. Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nickname:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 342);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Player Info";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // btnChooseTeams
            // 
            this.btnChooseTeams.Location = new System.Drawing.Point(24, 132);
            this.btnChooseTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseTeams.Name = "btnChooseTeams";
            this.btnChooseTeams.Size = new System.Drawing.Size(147, 28);
            this.btnChooseTeams.TabIndex = 11;
            this.btnChooseTeams.Text = "<< Game Setup";
            this.btnChooseTeams.UseVisualStyleBackColor = true;
            this.btnChooseTeams.Click += new System.EventHandler(this.btnChooseTeams_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Location = new System.Drawing.Point(24, 203);
            this.btnEditTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(147, 28);
            this.btnEditTeam.TabIndex = 13;
            this.btnEditTeam.Text = "Edit Existing Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnEnterNewTeam
            // 
            this.btnEnterNewTeam.Location = new System.Drawing.Point(24, 167);
            this.btnEnterNewTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnterNewTeam.Name = "btnEnterNewTeam";
            this.btnEnterNewTeam.Size = new System.Drawing.Size(147, 28);
            this.btnEnterNewTeam.TabIndex = 12;
            this.btnEnterNewTeam.Text = "Add Player";
            this.btnEnterNewTeam.UseVisualStyleBackColor = true;
            this.btnEnterNewTeam.Click += new System.EventHandler(this.btnEnterNewTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(201, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 97);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lax-Trax";
            // 
            // PlayerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(869, 540);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.pnlNewTeam);
            this.Controls.Add(this.btnChooseTeams);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnEnterNewTeam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Administration";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.pnlNewTeam.ResumeLayout(false);
            this.pnlNewTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdoGirls;
        private System.Windows.Forms.RadioButton rdoBoys;
        private System.Windows.Forms.Panel pnlNewTeam;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseTeams;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Button btnEnterNewTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJersey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTeamList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAwards;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGradYear;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPlayerList;
        private System.Windows.Forms.Label lblPlayer;
    }
}