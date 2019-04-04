using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.BringToFront();
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

        private void button3_Click(object sender, EventArgs e)
        {
            /*panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            userControl31.BringToFront();*/
        }
    }
}
