namespace Pavlov
{
    partial class Settings
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
            this.lblTrackingType = new System.Windows.Forms.Label();
            this.lblAlarmType = new System.Windows.Forms.Label();
            this.lblFoodAlarm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnHomon = new System.Windows.Forms.RadioButton();
            this.rbtnPet = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnOnce = new System.Windows.Forms.RadioButton();
            this.rbtnRepeat = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFoodLevel = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackingType
            // 
            this.lblTrackingType.AutoSize = true;
            this.lblTrackingType.Location = new System.Drawing.Point(4, 7);
            this.lblTrackingType.Name = "lblTrackingType";
            this.lblTrackingType.Size = new System.Drawing.Size(76, 13);
            this.lblTrackingType.TabIndex = 0;
            this.lblTrackingType.Text = "Tracking Type";
            // 
            // lblAlarmType
            // 
            this.lblAlarmType.AutoSize = true;
            this.lblAlarmType.Location = new System.Drawing.Point(4, 7);
            this.lblAlarmType.Name = "lblAlarmType";
            this.lblAlarmType.Size = new System.Drawing.Size(60, 13);
            this.lblAlarmType.TabIndex = 1;
            this.lblAlarmType.Text = "Alarm Type";
            // 
            // lblFoodAlarm
            // 
            this.lblFoodAlarm.AutoSize = true;
            this.lblFoodAlarm.Location = new System.Drawing.Point(4, 7);
            this.lblFoodAlarm.Name = "lblFoodAlarm";
            this.lblFoodAlarm.Size = new System.Drawing.Size(89, 13);
            this.lblFoodAlarm.TabIndex = 2;
            this.lblFoodAlarm.Text = "Alarm Food Level";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Canel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnHomon);
            this.panel1.Controls.Add(this.rbtnPet);
            this.panel1.Controls.Add(this.lblTrackingType);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 28);
            this.panel1.TabIndex = 10;
            // 
            // rbtnHomon
            // 
            this.rbtnHomon.AutoSize = true;
            this.rbtnHomon.Location = new System.Drawing.Point(165, 5);
            this.rbtnHomon.Name = "rbtnHomon";
            this.rbtnHomon.Size = new System.Drawing.Size(90, 17);
            this.rbtnHomon.TabIndex = 2;
            this.rbtnHomon.TabStop = true;
            this.rbtnHomon.Text = "Homonuculus";
            this.rbtnHomon.UseVisualStyleBackColor = true;
            // 
            // rbtnPet
            // 
            this.rbtnPet.AutoSize = true;
            this.rbtnPet.Location = new System.Drawing.Point(99, 5);
            this.rbtnPet.Name = "rbtnPet";
            this.rbtnPet.Size = new System.Drawing.Size(41, 17);
            this.rbtnPet.TabIndex = 1;
            this.rbtnPet.TabStop = true;
            this.rbtnPet.Text = "Pet";
            this.rbtnPet.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnOnce);
            this.panel2.Controls.Add(this.rbtnRepeat);
            this.panel2.Controls.Add(this.lblAlarmType);
            this.panel2.Location = new System.Drawing.Point(-3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 28);
            this.panel2.TabIndex = 11;
            // 
            // rbtnOnce
            // 
            this.rbtnOnce.AutoSize = true;
            this.rbtnOnce.Location = new System.Drawing.Point(165, 5);
            this.rbtnOnce.Name = "rbtnOnce";
            this.rbtnOnce.Size = new System.Drawing.Size(51, 17);
            this.rbtnOnce.TabIndex = 2;
            this.rbtnOnce.TabStop = true;
            this.rbtnOnce.Text = "Once";
            this.rbtnOnce.UseVisualStyleBackColor = true;
            // 
            // rbtnRepeat
            // 
            this.rbtnRepeat.AutoSize = true;
            this.rbtnRepeat.Location = new System.Drawing.Point(99, 5);
            this.rbtnRepeat.Name = "rbtnRepeat";
            this.rbtnRepeat.Size = new System.Drawing.Size(60, 17);
            this.rbtnRepeat.TabIndex = 1;
            this.rbtnRepeat.TabStop = true;
            this.rbtnRepeat.Text = "Repeat";
            this.rbtnRepeat.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFoodLevel);
            this.panel3.Controls.Add(this.lblFoodAlarm);
            this.panel3.Location = new System.Drawing.Point(-3, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 28);
            this.panel3.TabIndex = 12;
            // 
            // txtFoodLevel
            // 
            this.txtFoodLevel.Location = new System.Drawing.Point(99, 3);
            this.txtFoodLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFoodLevel.Name = "txtFoodLevel";
            this.txtFoodLevel.Size = new System.Drawing.Size(60, 20);
            this.txtFoodLevel.TabIndex = 3;
            this.txtFoodLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 130);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrackingType;
        private System.Windows.Forms.Label lblAlarmType;
        private System.Windows.Forms.Label lblFoodAlarm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnHomon;
        private System.Windows.Forms.RadioButton rbtnPet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnOnce;
        private System.Windows.Forms.RadioButton rbtnRepeat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown txtFoodLevel;
    }
}