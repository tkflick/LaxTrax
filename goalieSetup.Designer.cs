namespace ScoreLaxia
{
    partial class goalieSetup
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomeNumber = new System.Windows.Forms.Button();
            this.lblVisitingTeam = new System.Windows.Forms.Label();
            this.btnVisitorNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(194, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 35);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTeam.Location = new System.Drawing.Point(41, 53);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(169, 23);
            this.lblHomeTeam.TabIndex = 63;
            this.lblHomeTeam.Text = "Home Team Goalie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Select Current Goalies";
            // 
            // btnHomeNumber
            // 
            this.btnHomeNumber.BackColor = System.Drawing.Color.White;
            this.btnHomeNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeNumber.Location = new System.Drawing.Point(84, 85);
            this.btnHomeNumber.Name = "btnHomeNumber";
            this.btnHomeNumber.Size = new System.Drawing.Size(86, 37);
            this.btnHomeNumber.TabIndex = 59;
            this.btnHomeNumber.Text = "Goalie #";
            this.btnHomeNumber.UseVisualStyleBackColor = false;
            this.btnHomeNumber.Click += new System.EventHandler(this.btnHomeNumber_Click);
            // 
            // lblVisitingTeam
            // 
            this.lblVisitingTeam.AutoSize = true;
            this.lblVisitingTeam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitingTeam.Location = new System.Drawing.Point(246, 53);
            this.lblVisitingTeam.Name = "lblVisitingTeam";
            this.lblVisitingTeam.Size = new System.Drawing.Size(179, 23);
            this.lblVisitingTeam.TabIndex = 66;
            this.lblVisitingTeam.Text = "Visiting Team Goalie";
            // 
            // btnVisitorNumber
            // 
            this.btnVisitorNumber.BackColor = System.Drawing.Color.White;
            this.btnVisitorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorNumber.Location = new System.Drawing.Point(290, 85);
            this.btnVisitorNumber.Name = "btnVisitorNumber";
            this.btnVisitorNumber.Size = new System.Drawing.Size(86, 37);
            this.btnVisitorNumber.TabIndex = 65;
            this.btnVisitorNumber.Text = "Goalie #";
            this.btnVisitorNumber.UseVisualStyleBackColor = false;
            this.btnVisitorNumber.Click += new System.EventHandler(this.btnVisitorNumber_Click);
            // 
            // goalieSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 203);
            this.Controls.Add(this.lblVisitingTeam);
            this.Controls.Add(this.btnVisitorNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHomeNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "goalieSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Goalies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomeNumber;
        private System.Windows.Forms.Label lblVisitingTeam;
        private System.Windows.Forms.Button btnVisitorNumber;
    }
}