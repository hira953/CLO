using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            userControl21.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            userControl41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            userControl51.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            userControl61.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;
            userControl71.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
            userControl81.BringToFront();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
            userControl101.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Height = button10.Height;
            panel3.Top = button10.Top;
            userControl91.BringToFront();
        }
    }
}
