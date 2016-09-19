namespace Car_Rental
{
    partial class Form1
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
            this.chooseStyle = new System.Windows.Forms.Label();
            this.comboBox_style = new System.Windows.Forms.ComboBox();
            this.numericUpDown_days = new System.Windows.Forms.NumericUpDown();
            this.days = new System.Windows.Forms.Label();
            this.totalCharges = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseStyle
            // 
            this.chooseStyle.AutoSize = true;
            this.chooseStyle.Location = new System.Drawing.Point(46, 80);
            this.chooseStyle.Name = "chooseStyle";
            this.chooseStyle.Size = new System.Drawing.Size(69, 13);
            this.chooseStyle.TabIndex = 0;
            this.chooseStyle.Text = "Choose Style";
            // 
            // comboBox_style
            // 
            this.comboBox_style.FormattingEnabled = true;
            this.comboBox_style.Items.AddRange(new object[] {
            "Compact",
            "Standard",
            "Luxury"});
            this.comboBox_style.Location = new System.Drawing.Point(122, 80);
            this.comboBox_style.Name = "comboBox_style";
            this.comboBox_style.Size = new System.Drawing.Size(121, 21);
            this.comboBox_style.TabIndex = 1;
            this.comboBox_style.SelectedIndexChanged += new System.EventHandler(this.comboBox_style_SelectedIndexChanged);
            // 
            // numericUpDown_days
            // 
            this.numericUpDown_days.Location = new System.Drawing.Point(122, 108);
            this.numericUpDown_days.Name = "numericUpDown_days";
            this.numericUpDown_days.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_days.TabIndex = 2;
            this.numericUpDown_days.ValueChanged += new System.EventHandler(this.comboBox_style_SelectedIndexChanged);
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(49, 114);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(29, 13);
            this.days.TabIndex = 3;
            this.days.Text = "days";
            // 
            // totalCharges
            // 
            this.totalCharges.AutoSize = true;
            this.totalCharges.Location = new System.Drawing.Point(52, 145);
            this.totalCharges.Name = "totalCharges";
            this.totalCharges.Size = new System.Drawing.Size(35, 13);
            this.totalCharges.TabIndex = 4;
            this.totalCharges.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Car and Days to Rent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCharges);
            this.Controls.Add(this.days);
            this.Controls.Add(this.numericUpDown_days);
            this.Controls.Add(this.comboBox_style);
            this.Controls.Add(this.chooseStyle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_days)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseStyle;
        private System.Windows.Forms.ComboBox comboBox_style;
        private System.Windows.Forms.NumericUpDown numericUpDown_days;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label totalCharges;
        private System.Windows.Forms.Label label1;
    }
}

