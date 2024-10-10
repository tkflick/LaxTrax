namespace ScoreLaxia
{
    partial class Groundball
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
            this.btnPlayerNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomeTeam = new System.Windows.Forms.Button();
            this.btnVisitingTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayerNumber
            // 
            this.btnPlayerNumber.BackColor = System.Drawing.Color.White;
            this.btnPlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerNumber.Location = new System.Drawing.Point(160, 55);
            this.btnPlayerNumber.Name = "btnPlayerNumber";
            this.btnPlayerNumber.Size = new System.Drawing.Size(141, 37);
            this.btnPlayerNumber.TabIndex = 0;
            this.btnPlayerNumber.Text = "Select Player";
            this.btnPlayerNumber.UseVisualStyleBackColor = false;
            this.btnPlayerNumber.Click += new System.EventHandler(this.btnPlayerNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groundball Winner";
            // 
            // btnHomeTeam
            // 
            this.btnHomeTeam.BackColor = System.Drawing.Color.White;
            this.btnHomeTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeTeam.Location = new System.Drawing.Point(73, 139);
            this.btnHomeTeam.Name = "btnHomeTeam";
            this.btnHomeTeam.Size = new System.Drawing.Size(141, 37);
            this.btnHomeTeam.TabIndex = 2;
            this.btnHomeTeam.Text = "home team";
            this.btnHomeTeam.UseVisualStyleBackColor = false;
            this.btnHomeTeam.Click += new System.EventHandler(this.btnHomeTeam_Click);
            // 
            // btnVisitingTeam
            // 
            this.btnVisitingTeam.BackColor = System.Drawing.Color.White;
            this.btnVisitingTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitingTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitingTeam.Location = new System.Drawing.Point(243, 139);
            this.btnVisitingTeam.Name = "btnVisitingTeam";
            this.btnVisitingTeam.Size = new System.Drawing.Size(141, 37);
            this.btnVisitingTeam.TabIndex = 3;
            this.btnVisitingTeam.Text = "visitor";
            this.btnVisitingTeam.UseVisualStyleBackColor = false;
            this.btnVisitingTeam.Click += new System.EventHandler(this.btnVisitingTeam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Team";
            // 
            // Groundball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(474, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVisitingTeam);
            this.Controls.Add(this.btnHomeTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayerNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Groundball";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groundball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomeTeam;
        private System.Windows.Forms.Button btnVisitingTeam;
        private System.Windows.Forms.Label label2;
    }
}