namespace ScoreLaxia
{
    partial class AddNewTeam
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
            this.pnlNewTeam = new System.Windows.Forms.Panel();
            this.lblActionHeader = new System.Windows.Forms.Label();
            this.cmbTeamNames = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtMascot = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseTeams = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnEnterNewTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdoGirls = new System.Windows.Forms.RadioButton();
            this.rdoBoys = new System.Windows.Forms.RadioButton();
            this.pnlNewTeam.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewTeam
            // 
            this.pnlNewTeam.Controls.Add(this.lblActionHeader);
            this.pnlNewTeam.Controls.Add(this.cmbTeamNames);
            this.pnlNewTeam.Controls.Add(this.cmbGender);
            this.pnlNewTeam.Controls.Add(this.txtMascot);
            this.pnlNewTeam.Controls.Add(this.txtTeamName);
            this.pnlNewTeam.Controls.Add(this.label4);
            this.pnlNewTeam.Controls.Add(this.label3);
            this.pnlNewTeam.Controls.Add(this.btnStart);
            this.pnlNewTeam.Controls.Add(this.label2);
            this.pnlNewTeam.Location = new System.Drawing.Point(151, 104);
            this.pnlNewTeam.Name = "pnlNewTeam";
            this.pnlNewTeam.Size = new System.Drawing.Size(436, 246);
            this.pnlNewTeam.TabIndex = 15;
            // 
            // lblActionHeader
            // 
            this.lblActionHeader.AutoSize = true;
            this.lblActionHeader.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionHeader.Location = new System.Drawing.Point(12, 10);
            this.lblActionHeader.Name = "lblActionHeader";
            this.lblActionHeader.Size = new System.Drawing.Size(168, 23);
            this.lblActionHeader.TabIndex = 12;
            this.lblActionHeader.Text = "- Add New Team";
            // 
            // cmbTeamNames
            // 
            this.cmbTeamNames.FormattingEnabled = true;
            this.cmbTeamNames.Location = new System.Drawing.Point(140, 38);
            this.cmbTeamNames.Name = "cmbTeamNames";
            this.cmbTeamNames.Size = new System.Drawing.Size(133, 21);
            this.cmbTeamNames.TabIndex = 11;
            this.cmbTeamNames.Visible = false;
            this.cmbTeamNames.SelectedIndexChanged += new System.EventHandler(this.cmbTeamNames_SelectedIndexChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(140, 89);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(134, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // txtMascot
            // 
            this.txtMascot.Location = new System.Drawing.Point(140, 64);
            this.txtMascot.Name = "txtMascot";
            this.txtMascot.Size = new System.Drawing.Size(134, 20);
            this.txtMascot.TabIndex = 8;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(140, 38);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(134, 20);
            this.txtTeamName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mascot:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(92, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Save New Team";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team Name:";
            // 
            // btnChooseTeams
            // 
            this.btnChooseTeams.Location = new System.Drawing.Point(18, 107);
            this.btnChooseTeams.Name = "btnChooseTeams";
            this.btnChooseTeams.Size = new System.Drawing.Size(110, 23);
            this.btnChooseTeams.TabIndex = 14;
            this.btnChooseTeams.Text = "<< Game Setup";
            this.btnChooseTeams.UseVisualStyleBackColor = true;
            this.btnChooseTeams.Click += new System.EventHandler(this.btnChooseTeams_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Location = new System.Drawing.Point(18, 165);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(110, 23);
            this.btnEditTeam.TabIndex = 13;
            this.btnEditTeam.Text = "Edit Existing Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnEnterNewTeam
            // 
            this.btnEnterNewTeam.Location = new System.Drawing.Point(18, 136);
            this.btnEnterNewTeam.Name = "btnEnterNewTeam";
            this.btnEnterNewTeam.Size = new System.Drawing.Size(110, 23);
            this.btnEnterNewTeam.TabIndex = 11;
            this.btnEnterNewTeam.Text = "Enter New Team";
            this.btnEnterNewTeam.UseVisualStyleBackColor = true;
            this.btnEnterNewTeam.Click += new System.EventHandler(this.btnEnterNewTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 77);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lax-Trax";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdoGirls);
            this.gbGender.Controls.Add(this.rdoBoys);
            this.gbGender.Location = new System.Drawing.Point(18, 198);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(110, 100);
            this.gbGender.TabIndex = 17;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            this.gbGender.Visible = false;
            // 
            // rdoGirls
            // 
            this.rdoGirls.AutoSize = true;
            this.rdoGirls.Location = new System.Drawing.Point(24, 49);
            this.rdoGirls.Name = "rdoGirls";
            this.rdoGirls.Size = new System.Drawing.Size(80, 17);
            this.rdoGirls.TabIndex = 18;
            this.rdoGirls.TabStop = true;
            this.rdoGirls.Text = "Girls Teams";
            this.rdoGirls.UseVisualStyleBackColor = true;
            this.rdoGirls.Visible = false;
            this.rdoGirls.CheckedChanged += new System.EventHandler(this.rdoGirls_CheckedChanged);
            // 
            // rdoBoys
            // 
            this.rdoBoys.AutoSize = true;
            this.rdoBoys.Location = new System.Drawing.Point(24, 26);
            this.rdoBoys.Name = "rdoBoys";
            this.rdoBoys.Size = new System.Drawing.Size(83, 17);
            this.rdoBoys.TabIndex = 17;
            this.rdoBoys.TabStop = true;
            this.rdoBoys.Text = "Boys Teams";
            this.rdoBoys.UseVisualStyleBackColor = true;
            this.rdoBoys.Visible = false;
            this.rdoBoys.CheckedChanged += new System.EventHandler(this.rdoBoys_CheckedChanged);
            // 
            // AddNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(662, 451);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.pnlNewTeam);
            this.Controls.Add(this.btnChooseTeams);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.btnEnterNewTeam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Administration";
            this.pnlNewTeam.ResumeLayout(false);
            this.pnlNewTeam.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewTeam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseTeams;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Button btnEnterNewTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtMascot;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblActionHeader;
        private System.Windows.Forms.ComboBox cmbTeamNames;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdoGirls;
        private System.Windows.Forms.RadioButton rdoBoys;
    }
}