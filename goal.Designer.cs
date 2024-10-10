namespace ScoreLaxia
{
    partial class goal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goal));
            this.pbTimerStop = new System.Windows.Forms.PictureBox();
            this.pbTimerStart = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisitingTeam = new System.Windows.Forms.Button();
            this.btnHomeTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayerNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTimerStop
            // 
            this.pbTimerStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTimerStop.ErrorImage = null;
            this.pbTimerStop.Image = ((System.Drawing.Image)(resources.GetObject("pbTimerStop.Image")));
            this.pbTimerStop.ImageLocation = "";
            this.pbTimerStop.InitialImage = null;
            this.pbTimerStop.Location = new System.Drawing.Point(383, 38);
            this.pbTimerStop.Name = "pbTimerStop";
            this.pbTimerStop.Size = new System.Drawing.Size(50, 45);
            this.pbTimerStop.TabIndex = 67;
            this.pbTimerStop.TabStop = false;
            // 
            // pbTimerStart
            // 
            this.pbTimerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTimerStart.ErrorImage = null;
            this.pbTimerStart.Image = ((System.Drawing.Image)(resources.GetObject("pbTimerStart.Image")));
            this.pbTimerStart.ImageLocation = "";
            this.pbTimerStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTimerStart.InitialImage")));
            this.pbTimerStart.Location = new System.Drawing.Point(41, 36);
            this.pbTimerStart.Name = "pbTimerStart";
            this.pbTimerStart.Size = new System.Drawing.Size(49, 47);
            this.pbTimerStart.TabIndex = 66;
            this.pbTimerStart.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(196, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "LOG GOAL";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "Select Team";
            // 
            // btnVisitingTeam
            // 
            this.btnVisitingTeam.BackColor = System.Drawing.Color.White;
            this.btnVisitingTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitingTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitingTeam.Location = new System.Drawing.Point(251, 117);
            this.btnVisitingTeam.Name = "btnVisitingTeam";
            this.btnVisitingTeam.Size = new System.Drawing.Size(141, 37);
            this.btnVisitingTeam.TabIndex = 62;
            this.btnVisitingTeam.Text = "visitor";
            this.btnVisitingTeam.UseVisualStyleBackColor = false;
            this.btnVisitingTeam.Click += new System.EventHandler(this.btnVisitingTeam_Click);
            // 
            // btnHomeTeam
            // 
            this.btnHomeTeam.BackColor = System.Drawing.Color.White;
            this.btnHomeTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeTeam.Location = new System.Drawing.Point(81, 117);
            this.btnHomeTeam.Name = "btnHomeTeam";
            this.btnHomeTeam.Size = new System.Drawing.Size(141, 37);
            this.btnHomeTeam.TabIndex = 61;
            this.btnHomeTeam.Text = "home team";
            this.btnHomeTeam.UseVisualStyleBackColor = false;
            this.btnHomeTeam.Click += new System.EventHandler(this.btnHomeTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Player Who Took Shot";
            // 
            // btnPlayerNumber
            // 
            this.btnPlayerNumber.BackColor = System.Drawing.Color.White;
            this.btnPlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerNumber.Location = new System.Drawing.Point(168, 36);
            this.btnPlayerNumber.Name = "btnPlayerNumber";
            this.btnPlayerNumber.Size = new System.Drawing.Size(141, 37);
            this.btnPlayerNumber.TabIndex = 59;
            this.btnPlayerNumber.Text = "Enter Player #";
            this.btnPlayerNumber.UseVisualStyleBackColor = false;
            this.btnPlayerNumber.Click += new System.EventHandler(this.btnPlayerNumber_Click);
            // 
            // goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 203);
            this.Controls.Add(this.pbTimerStop);
            this.Controls.Add(this.pbTimerStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVisitingTeam);
            this.Controls.Add(this.btnHomeTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "goal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Scored Goal";
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTimerStop;
        private System.Windows.Forms.PictureBox pbTimerStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisitingTeam;
        private System.Windows.Forms.Button btnHomeTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayerNumber;
    }
}