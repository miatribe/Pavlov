namespace Pavlov
{
    partial class Pavlov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pavlov));
            this.petNameLabel = new System.Windows.Forms.Label();
            this.bestFeedLabel = new System.Windows.Forms.Label();
            this.intimacyLabel = new System.Windows.Forms.Label();
            this.hungerLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.NextClientBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextClientBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.petNameLabel.Location = new System.Drawing.Point(1, 83);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(0, 13);
            this.petNameLabel.TabIndex = 4;
            this.petNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // bestFeedLabel
            // 
            this.bestFeedLabel.AutoSize = true;
            this.bestFeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestFeedLabel.Location = new System.Drawing.Point(1, 61);
            this.bestFeedLabel.Name = "bestFeedLabel";
            this.bestFeedLabel.Size = new System.Drawing.Size(0, 13);
            this.bestFeedLabel.TabIndex = 5;
            this.bestFeedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // intimacyLabel
            // 
            this.intimacyLabel.AutoSize = true;
            this.intimacyLabel.BackColor = System.Drawing.Color.Transparent;
            this.intimacyLabel.Location = new System.Drawing.Point(1, 41);
            this.intimacyLabel.Name = "intimacyLabel";
            this.intimacyLabel.Size = new System.Drawing.Size(0, 13);
            this.intimacyLabel.TabIndex = 6;
            this.intimacyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // hungerLabel
            // 
            this.hungerLabel.AutoSize = true;
            this.hungerLabel.BackColor = System.Drawing.Color.Transparent;
            this.hungerLabel.Location = new System.Drawing.Point(1, 22);
            this.hungerLabel.Name = "hungerLabel";
            this.hungerLabel.Size = new System.Drawing.Size(0, 13);
            this.hungerLabel.TabIndex = 7;
            this.hungerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Pavlov.Properties.Resources.dot;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(9, 9);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(13, 2);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLbl.Size = new System.Drawing.Size(79, 13);
            this.titleLbl.TabIndex = 11;
            this.titleLbl.Text = "Pavlov by Tribe";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitBtn.Image = global::Pavlov.Properties.Resources.close;
            this.ExitBtn.Location = new System.Drawing.Point(145, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(9, 9);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NextClientBtn
            // 
            this.NextClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextClientBtn.Image = global::Pavlov.Properties.Resources.arrow;
            this.NextClientBtn.Location = new System.Drawing.Point(147, 85);
            this.NextClientBtn.Name = "NextClientBtn";
            this.NextClientBtn.Size = new System.Drawing.Size(6, 9);
            this.NextClientBtn.TabIndex = 13;
            this.NextClientBtn.TabStop = false;
            this.NextClientBtn.Click += new System.EventHandler(this.NextClientBtn_Click);
            // 
            // Pavlov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pavlov.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(158, 100);
            this.Controls.Add(this.NextClientBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.hungerLabel);
            this.Controls.Add(this.intimacyLabel);
            this.Controls.Add(this.bestFeedLabel);
            this.Controls.Add(this.petNameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pavlov";
            this.RightToLeftLayout = true;
            this.Text = "Pavlov";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pavlov_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextClientBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label bestFeedLabel;
        private System.Windows.Forms.Label intimacyLabel;
        private System.Windows.Forms.Label hungerLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox NextClientBtn;
    }
}

