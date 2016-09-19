using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = 0;
            int days = (int)numericUpDown_days.Value;
            switch(comboBox_style.SelectedIndex)
            {
                case 0:
                    total = 19.95 * days;  
                    break;
                case 1:
                    total = 24.95 * days;
                    break;
                case 2:
                    total = 39 * days;
                    break;
            }

            totalCharges.Text = total.ToString();
        }
    }
}
