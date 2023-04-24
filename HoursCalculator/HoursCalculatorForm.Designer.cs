namespace HoursCalculator
{
    partial class hoursCalculatorForm
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
            this.startTime = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.AMorPMCombobox1 = new System.Windows.Forms.ComboBox();
            this.AMorPMCombobox2 = new System.Windows.Forms.ComboBox();
            this.hour1TextBox = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.minute2TextBox = new System.Windows.Forms.TextBox();
            this.minute1TextBox = new System.Windows.Forms.TextBox();
            this.hour2TextBox = new System.Windows.Forms.TextBox();
            this.hourMinuteResultText = new System.Windows.Forms.Label();
            this.hourMinuteResultText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Location = new System.Drawing.Point(295, 131);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(158, 31);
            this.startTime.TabIndex = 0;
            this.startTime.Text = "Start Time:";
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Location = new System.Drawing.Point(295, 205);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(157, 33);
            this.endTime.TabIndex = 1;
            this.endTime.Text = "End Time:";
            // 
            // AMorPMCombobox1
            // 
            this.AMorPMCombobox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AMorPMCombobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMorPMCombobox1.FormattingEnabled = true;
            this.AMorPMCombobox1.Location = new System.Drawing.Point(583, 131);
            this.AMorPMCombobox1.Name = "AMorPMCombobox1";
            this.AMorPMCombobox1.Size = new System.Drawing.Size(63, 37);
            this.AMorPMCombobox1.TabIndex = 2;
            // 
            // AMorPMCombobox2
            // 
            this.AMorPMCombobox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AMorPMCombobox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMorPMCombobox2.FormattingEnabled = true;
            this.AMorPMCombobox2.Location = new System.Drawing.Point(583, 201);
            this.AMorPMCombobox2.Name = "AMorPMCombobox2";
            this.AMorPMCombobox2.Size = new System.Drawing.Size(63, 37);
            this.AMorPMCombobox2.TabIndex = 3;
            // 
            // hour1TextBox
            // 
            this.hour1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour1TextBox.Location = new System.Drawing.Point(459, 131);
            this.hour1TextBox.Name = "hour1TextBox";
            this.hour1TextBox.Size = new System.Drawing.Size(41, 35);
            this.hour1TextBox.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(314, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 46);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(506, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 46);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // minute2TextBox
            // 
            this.minute2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute2TextBox.Location = new System.Drawing.Point(506, 203);
            this.minute2TextBox.Name = "minute2TextBox";
            this.minute2TextBox.Size = new System.Drawing.Size(41, 35);
            this.minute2TextBox.TabIndex = 10;
            // 
            // minute1TextBox
            // 
            this.minute1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute1TextBox.Location = new System.Drawing.Point(506, 131);
            this.minute1TextBox.Name = "minute1TextBox";
            this.minute1TextBox.Size = new System.Drawing.Size(41, 35);
            this.minute1TextBox.TabIndex = 11;
            // 
            // hour2TextBox
            // 
            this.hour2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour2TextBox.Location = new System.Drawing.Point(458, 203);
            this.hour2TextBox.Name = "hour2TextBox";
            this.hour2TextBox.Size = new System.Drawing.Size(41, 35);
            this.hour2TextBox.TabIndex = 12;
            // 
            // hourMinuteResultText
            // 
            this.hourMinuteResultText.AutoSize = true;
            this.hourMinuteResultText.BackColor = System.Drawing.SystemColors.Control;
            this.hourMinuteResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteResultText.ForeColor = System.Drawing.Color.Black;
            this.hourMinuteResultText.Location = new System.Drawing.Point(294, 428);
            this.hourMinuteResultText.Name = "hourMinuteResultText";
            this.hourMinuteResultText.Size = new System.Drawing.Size(478, 39);
            this.hourMinuteResultText.TabIndex = 13;
            this.hourMinuteResultText.Text = "Put Hours and Minutes Here";
            // 
            // hourMinuteResultText2
            // 
            this.hourMinuteResultText2.AutoSize = true;
            this.hourMinuteResultText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteResultText2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hourMinuteResultText2.Location = new System.Drawing.Point(296, 386);
            this.hourMinuteResultText2.Name = "hourMinuteResultText2";
            this.hourMinuteResultText2.Size = new System.Drawing.Size(235, 25);
            this.hourMinuteResultText2.TabIndex = 14;
            this.hourMinuteResultText2.Text = "hourMinuteResultText2";
            // 
            // hoursCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 559);
            this.Controls.Add(this.hourMinuteResultText2);
            this.Controls.Add(this.hourMinuteResultText);
            this.Controls.Add(this.hour2TextBox);
            this.Controls.Add(this.minute1TextBox);
            this.Controls.Add(this.minute2TextBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.hour1TextBox);
            this.Controls.Add(this.AMorPMCombobox2);
            this.Controls.Add(this.AMorPMCombobox1);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "hoursCalculatorForm";
            this.Text = "Hours Calculator Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.ComboBox AMorPMCombobox1;
        private System.Windows.Forms.ComboBox AMorPMCombobox2;
        private System.Windows.Forms.TextBox hour1TextBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox minute2TextBox;
        private System.Windows.Forms.TextBox minute1TextBox;
        private System.Windows.Forms.TextBox hour2TextBox;
        private System.Windows.Forms.Label hourMinuteResultText;
        private System.Windows.Forms.Label hourMinuteResultText2;
    }
}

