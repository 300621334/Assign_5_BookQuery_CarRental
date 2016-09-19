using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineSubdivision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = -1;
            listBox3.SelectedIndex = -1;
            listBox4.SelectedIndex = -1;

            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Visible = true;
                listBox3.Visible = false;
                listBox4.Visible = false;
                label_choose_color.Visible = false;
                label_Choose_trim.Visible = true;

            }
            if (listBox1.SelectedIndex == 3)
            {
                listBox2.Visible = false;
                listBox3.Visible = true;
                listBox4.Visible = false;
                label_choose_color.Visible = false;
                label_Choose_trim.Visible = true;


            }
            if (listBox1.SelectedIndex == 5)
            {
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = true;
                label_choose_color.Visible = false;
                label_Choose_trim.Visible = true;


            }

            if (listBox1.SelectedIndex != 1 && listBox1.SelectedIndex != 3 && listBox1.SelectedIndex != 5)
            {
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
            }
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            message.Visible = false;
            if (listBox2.SelectedIndex == 0 || listBox2.SelectedIndex == 2 || listBox2.SelectedIndex == 4 || listBox2.SelectedIndex == 6)
            {
                message.Text = "You made a good choice!";
                message.Visible = true;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                label_Choose_trim.Visible = false;
                label_choose_color.Visible = true;

                //listBox2.SelectedIndex = -1;
                //listBox3.SelectedIndex = -1;
                //listBox4.SelectedIndex = -1;

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            message.Visible = false;
            if (listBox3.SelectedIndex == 2 || listBox3.SelectedIndex == 4)
            {
                message.Text = "You made a good choice!";
                message.Visible = true;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                label_Choose_trim.Visible = false;
                label_choose_color.Visible = true;
                //listBox2.SelectedIndex = -1;
                //listBox3.SelectedIndex = -1;
                //listBox4.SelectedIndex = -1;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            message.Visible = false;
            if (listBox4.SelectedIndex == 2 || listBox4.SelectedIndex == 4)
            {
                message.Text = "You made a good choice!";
                message.Visible = true;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                label_Choose_trim.Visible = false;
                label_choose_color.Visible = true;
                //listBox2.SelectedIndex = -1;
                //listBox3.SelectedIndex = -1;
                //listBox4.SelectedIndex = -1;
            }
        }
    }
}
