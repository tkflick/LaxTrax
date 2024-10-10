namespace ScoreLaxia
{
    partial class faceoff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faceoff));
            this.button1 = new System.Windows.Forms.Button();
            this.lblHomePlayer = new System.Windows.Forms.Label();
            this.lblVisitorPlayer = new System.Windows.Forms.Label();
            this.pbTimerStart = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pbTimerStop = new System.Windows.Forms.PictureBox();
            this.btnVTFOWin = new System.Windows.Forms.Button();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.txtVisitingTeam = new System.Windows.Forms.TextBox();
            this.btnHomePlayer = new System.Windows.Forms.Button();
            this.btnVisitorPlayer = new System.Windows.Forms.Button();
            this.btnHTFOWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Groundball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHomePlayer
            // 
            this.lblHomePlayer.AutoSize = true;
            this.lblHomePlayer.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePlayer.Location = new System.Drawing.Point(249, 28);
            this.lblHomePlayer.Name = "lblHomePlayer";
            this.lblHomePlayer.Size = new System.Drawing.Size(91, 18);
            this.lblHomePlayer.TabIndex = 5;
            this.lblHomePlayer.Text = "Home Player";
            // 
            // lblVisitorPlayer
            // 
            this.lblVisitorPlayer.AutoSize = true;
            this.lblVisitorPlayer.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorPlayer.Location = new System.Drawing.Point(249, 61);
            this.lblVisitorPlayer.Name = "lblVisitorPlayer";
            this.lblVisitorPlayer.Size = new System.Drawing.Size(95, 18);
            this.lblVisitorPlayer.TabIndex = 6;
            this.lblVisitorPlayer.Text = "Visiting Player";
            // 
            // pbTimerStart
            // 
            this.pbTimerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTimerStart.ErrorImage = null;
            this.pbTimerStart.Image = ((System.Drawing.Image)(resources.GetObject("pbTimerStart.Image")));
            this.pbTimerStart.ImageLocation = "";
            this.pbTimerStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTimerStart.InitialImage")));
            this.pbTimerStart.Location = new System.Drawing.Point(399, 28);
            this.pbTimerStart.Name = "pbTimerStart";
            this.pbTimerStart.Size = new System.Drawing.Size(49, 47);
            this.pbTimerStart.TabIndex = 51;
            this.pbTimerStart.TabStop = false;
            this.pbTimerStart.Click += new System.EventHandler(this.pbTimerStart_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Faceoff Violation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 55;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pbTimerStop
            // 
            this.pbTimerStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTimerStop.ErrorImage = null;
            this.pbTimerStop.Image = ((System.Drawing.Image)(resources.GetObject("pbTimerStop.Image")));
            this.pbTimerStop.ImageLocation = "";
            this.pbTimerStop.InitialImage = null;
            this.pbTimerStop.Location = new System.Drawing.Point(398, 81);
            this.pbTimerStop.Name = "pbTimerStop";
            this.pbTimerStop.Size = new System.Drawing.Size(50, 45);
            this.pbTimerStop.TabIndex = 56;
            this.pbTimerStop.TabStop = false;
            this.pbTimerStop.Click += new System.EventHandler(this.pbTimerStop_Click);
            // 
            // btnVTFOWin
            // 
            this.btnVTFOWin.Location = new System.Drawing.Point(363, 59);
            this.btnVTFOWin.Name = "btnVTFOWin";
            this.btnVTFOWin.Size = new System.Drawing.Size(20, 23);
            this.btnVTFOWin.TabIndex = 58;
            this.btnVTFOWin.UseVisualStyleBackColor = true;
            this.btnVTFOWin.Click += new System.EventHandler(this.btnVTFOWin_Click);
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtHomeTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomeTeam.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeTeam.Location = new System.Drawing.Point(20, 28);
            this.txtHomeTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.Size = new System.Drawing.Size(194, 18);
            this.txtHomeTeam.TabIndex = 59;
            this.txtHomeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVisitingTeam
            // 
            this.txtVisitingTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtVisitingTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVisitingTeam.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitingTeam.Location = new System.Drawing.Point(20, 60);
            this.txtVisitingTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVisitingTeam.Name = "txtVisitingTeam";
            this.txtVisitingTeam.Size = new System.Drawing.Size(194, 18);
            this.txtVisitingTeam.TabIndex = 60;
            this.txtVisitingTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHomePlayer
            // 
            this.btnHomePlayer.BackColor = System.Drawing.Color.White;
            this.btnHomePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePlayer.Location = new System.Drawing.Point(219, 28);
            this.btnHomePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHomePlayer.Name = "btnHomePlayer";
            this.btnHomePlayer.Size = new System.Drawing.Size(24, 23);
            this.btnHomePlayer.TabIndex = 61;
            this.btnHomePlayer.UseVisualStyleBackColor = false;
            this.btnHomePlayer.Click += new System.EventHandler(this.btnHomePlayer_Click);
            // 
            // btnVisitorPlayer
            // 
            this.btnVisitorPlayer.BackColor = System.Drawing.Color.White;
            this.btnVisitorPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorPlayer.Location = new System.Drawing.Point(219, 59);
            this.btnVisitorPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisitorPlayer.Name = "btnVisitorPlayer";
            this.btnVisitorPlayer.Size = new System.Drawing.Size(24, 23);
            this.btnVisitorPlayer.TabIndex = 62;
            this.btnVisitorPlayer.UseVisualStyleBackColor = false;
            this.btnVisitorPlayer.Click += new System.EventHandler(this.btnVisitorPlayer_Click);
            // 
            // btnHTFOWin
            // 
            this.btnHTFOWin.Location = new System.Drawing.Point(363, 28);
            this.btnHTFOWin.Name = "btnHTFOWin";
            this.btnHTFOWin.Size = new System.Drawing.Size(20, 23);
            this.btnHTFOWin.TabIndex = 64;
            this.btnHTFOWin.UseVisualStyleBackColor = true;
            this.btnHTFOWin.Click += new System.EventHandler(this.btnHTFOWin_Click);
            // 
            // faceoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(473, 146);
            this.Controls.Add(this.btnHTFOWin);
            this.Controls.Add(this.btnVisitorPlayer);
            this.Controls.Add(this.btnHomePlayer);
            this.Controls.Add(this.txtVisitingTeam);
            this.Controls.Add(this.txtHomeTeam);
            this.Controls.Add(this.btnVTFOWin);
            this.Controls.Add(this.pbTimerStop);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pbTimerStart);
            this.Controls.Add(this.lblVisitorPlayer);
            this.Controls.Add(this.lblHomePlayer);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "faceoff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faceoff..";
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHomePlayer;
        private System.Windows.Forms.Label lblVisitorPlayer;
        private System.Windows.Forms.PictureBox pbTimerStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbTimerStop;
        private System.Windows.Forms.Button btnVTFOWin;
        private System.Windows.Forms.TextBox txtHomeTeam;
        private System.Windows.Forms.TextBox txtVisitingTeam;
        private System.Windows.Forms.Button btnHomePlayer;
        private System.Windows.Forms.Button btnVisitorPlayer;
        private System.Windows.Forms.Button btnHTFOWin;
    }
}