namespace ScoreLaxia
{
    partial class penalty
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVisitorPlayerNumber = new System.Windows.Forms.Button();
            this.btnHomePlayerNumber = new System.Windows.Forms.Button();
            this.ddlHomePenalty = new System.Windows.Forms.ComboBox();
            this.ddlVisitorPenalty = new System.Windows.Forms.ComboBox();
            this.ddlHomeTime = new System.Windows.Forms.ComboBox();
            this.ddlVisitorTime = new System.Windows.Forms.ComboBox();
            this.ddlVisitorRelease = new System.Windows.Forms.ComboBox();
            this.ddlHomeRelease = new System.Windows.Forms.ComboBox();
            this.btnVisitingTeam = new System.Windows.Forms.Button();
            this.btnHomeTeam = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penalty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Releaseable?";
            // 
            // btnVisitorPlayerNumber
            // 
            this.btnVisitorPlayerNumber.BackColor = System.Drawing.Color.White;
            this.btnVisitorPlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorPlayerNumber.Location = new System.Drawing.Point(166, 115);
            this.btnVisitorPlayerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisitorPlayerNumber.Name = "btnVisitorPlayerNumber";
            this.btnVisitorPlayerNumber.Size = new System.Drawing.Size(37, 23);
            this.btnVisitorPlayerNumber.TabIndex = 63;
            this.btnVisitorPlayerNumber.UseVisualStyleBackColor = false;
            this.btnVisitorPlayerNumber.Visible = false;
            this.btnVisitorPlayerNumber.Click += new System.EventHandler(this.btnVisitorPlayerNumber_Click);
            // 
            // btnHomePlayerNumber
            // 
            this.btnHomePlayerNumber.BackColor = System.Drawing.Color.White;
            this.btnHomePlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePlayerNumber.Location = new System.Drawing.Point(166, 67);
            this.btnHomePlayerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomePlayerNumber.Name = "btnHomePlayerNumber";
            this.btnHomePlayerNumber.Size = new System.Drawing.Size(37, 23);
            this.btnHomePlayerNumber.TabIndex = 64;
            this.btnHomePlayerNumber.UseVisualStyleBackColor = false;
            this.btnHomePlayerNumber.Visible = false;
            this.btnHomePlayerNumber.Click += new System.EventHandler(this.btnHomePlayerNumber_Click);
            // 
            // ddlHomePenalty
            // 
            this.ddlHomePenalty.FormattingEnabled = true;
            this.ddlHomePenalty.Location = new System.Drawing.Point(210, 67);
            this.ddlHomePenalty.Name = "ddlHomePenalty";
            this.ddlHomePenalty.Size = new System.Drawing.Size(169, 21);
            this.ddlHomePenalty.TabIndex = 65;
            this.ddlHomePenalty.Visible = false;
            // 
            // ddlVisitorPenalty
            // 
            this.ddlVisitorPenalty.FormattingEnabled = true;
            this.ddlVisitorPenalty.Location = new System.Drawing.Point(210, 116);
            this.ddlVisitorPenalty.Name = "ddlVisitorPenalty";
            this.ddlVisitorPenalty.Size = new System.Drawing.Size(169, 21);
            this.ddlVisitorPenalty.TabIndex = 66;
            this.ddlVisitorPenalty.Visible = false;
            // 
            // ddlHomeTime
            // 
            this.ddlHomeTime.FormattingEnabled = true;
            this.ddlHomeTime.Location = new System.Drawing.Point(390, 67);
            this.ddlHomeTime.Name = "ddlHomeTime";
            this.ddlHomeTime.Size = new System.Drawing.Size(76, 21);
            this.ddlHomeTime.TabIndex = 67;
            this.ddlHomeTime.Visible = false;
            // 
            // ddlVisitorTime
            // 
            this.ddlVisitorTime.FormattingEnabled = true;
            this.ddlVisitorTime.Location = new System.Drawing.Point(390, 115);
            this.ddlVisitorTime.Name = "ddlVisitorTime";
            this.ddlVisitorTime.Size = new System.Drawing.Size(76, 21);
            this.ddlVisitorTime.TabIndex = 68;
            this.ddlVisitorTime.Visible = false;
            // 
            // ddlVisitorRelease
            // 
            this.ddlVisitorRelease.FormattingEnabled = true;
            this.ddlVisitorRelease.Location = new System.Drawing.Point(489, 115);
            this.ddlVisitorRelease.Name = "ddlVisitorRelease";
            this.ddlVisitorRelease.Size = new System.Drawing.Size(76, 21);
            this.ddlVisitorRelease.TabIndex = 69;
            this.ddlVisitorRelease.Visible = false;
            // 
            // ddlHomeRelease
            // 
            this.ddlHomeRelease.FormattingEnabled = true;
            this.ddlHomeRelease.Location = new System.Drawing.Point(489, 67);
            this.ddlHomeRelease.Name = "ddlHomeRelease";
            this.ddlHomeRelease.Size = new System.Drawing.Size(76, 21);
            this.ddlHomeRelease.TabIndex = 70;
            this.ddlHomeRelease.Visible = false;
            // 
            // btnVisitingTeam
            // 
            this.btnVisitingTeam.BackColor = System.Drawing.Color.White;
            this.btnVisitingTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitingTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitingTeam.Location = new System.Drawing.Point(11, 106);
            this.btnVisitingTeam.Name = "btnVisitingTeam";
            this.btnVisitingTeam.Size = new System.Drawing.Size(141, 37);
            this.btnVisitingTeam.TabIndex = 72;
            this.btnVisitingTeam.Text = "visitor";
            this.btnVisitingTeam.UseVisualStyleBackColor = false;
            this.btnVisitingTeam.Click += new System.EventHandler(this.btnVisitingTeam_Click);
            // 
            // btnHomeTeam
            // 
            this.btnHomeTeam.BackColor = System.Drawing.Color.White;
            this.btnHomeTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeTeam.Location = new System.Drawing.Point(12, 58);
            this.btnHomeTeam.Name = "btnHomeTeam";
            this.btnHomeTeam.Size = new System.Drawing.Size(141, 37);
            this.btnHomeTeam.TabIndex = 71;
            this.btnHomeTeam.Text = "home team";
            this.btnHomeTeam.UseVisualStyleBackColor = false;
            this.btnHomeTeam.Click += new System.EventHandler(this.btnHomeTeam_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(229, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 29);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(229, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 29);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(589, 236);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnVisitingTeam);
            this.Controls.Add(this.btnHomeTeam);
            this.Controls.Add(this.ddlHomeRelease);
            this.Controls.Add(this.ddlVisitorRelease);
            this.Controls.Add(this.ddlVisitorTime);
            this.Controls.Add(this.ddlHomeTime);
            this.Controls.Add(this.ddlVisitorPenalty);
            this.Controls.Add(this.ddlHomePenalty);
            this.Controls.Add(this.btnHomePlayerNumber);
            this.Controls.Add(this.btnVisitorPlayerNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "penalty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Committed Penalty";
            this.Load += new System.EventHandler(this.penalty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVisitorPlayerNumber;
        private System.Windows.Forms.Button btnHomePlayerNumber;
        private System.Windows.Forms.ComboBox ddlHomePenalty;
        private System.Windows.Forms.ComboBox ddlVisitorPenalty;
        private System.Windows.Forms.ComboBox ddlHomeTime;
        private System.Windows.Forms.ComboBox ddlVisitorTime;
        private System.Windows.Forms.ComboBox ddlVisitorRelease;
        private System.Windows.Forms.ComboBox ddlHomeRelease;
        private System.Windows.Forms.Button btnVisitingTeam;
        private System.Windows.Forms.Button btnHomeTeam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}