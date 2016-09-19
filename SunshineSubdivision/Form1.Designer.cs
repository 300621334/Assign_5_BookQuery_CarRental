namespace SunshineSubdivision
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.message = new System.Windows.Forms.Label();
            this.label_choose_color = new System.Windows.Forms.Label();
            this.label_Choose_trim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "-",
            "White",
            "-",
            "Gray",
            "-",
            "Blue",
            "-"});
            this.listBox1.Location = new System.Drawing.Point(29, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(44, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Black",
            "-",
            "Green",
            "-",
            "Dark",
            "-",
            "Blue"});
            this.listBox2.Location = new System.Drawing.Point(80, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(83, 95);
            this.listBox2.TabIndex = 1;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "-",
            "-",
            "Black",
            "-",
            "White",
            "-",
            "-"});
            this.listBox3.Location = new System.Drawing.Point(169, 73);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(83, 95);
            this.listBox3.TabIndex = 2;
            this.listBox3.Visible = false;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "-",
            "-",
            "White",
            "-",
            "Dark Blue",
            "-",
            "-"});
            this.listBox4.Location = new System.Drawing.Point(258, 73);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(83, 95);
            this.listBox4.TabIndex = 3;
            this.listBox4.Visible = false;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(29, 175);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 4;
            // 
            // label_choose_color
            // 
            this.label_choose_color.AutoSize = true;
            this.label_choose_color.Location = new System.Drawing.Point(29, 23);
            this.label_choose_color.Name = "label_choose_color";
            this.label_choose_color.Size = new System.Drawing.Size(73, 13);
            this.label_choose_color.TabIndex = 5;
            this.label_choose_color.Text = "Coose a Color";
            // 
            // label_Choose_trim
            // 
            this.label_Choose_trim.AutoSize = true;
            this.label_Choose_trim.Location = new System.Drawing.Point(29, 47);
            this.label_Choose_trim.Name = "label_Choose_trim";
            this.label_Choose_trim.Size = new System.Drawing.Size(75, 13);
            this.label_Choose_trim.TabIndex = 6;
            this.label_Choose_trim.Text = "Choose a Trim";
            this.label_Choose_trim.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 282);
            this.Controls.Add(this.label_Choose_trim);
            this.Controls.Add(this.label_choose_color);
            this.Controls.Add(this.message);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label_choose_color;
        private System.Windows.Forms.Label label_Choose_trim;
    }
}

