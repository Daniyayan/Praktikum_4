using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_1_1204016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Top -= e.Y;
            button1.Left += e.X;
            if (button1.Top < -16 || button1.Top > 16)
            {
                button1.Top = 73;
            }

            if (button1.Left < -64 || button1.Left > 160)
            {
                button1.Left = 160;
            }
        }

        private void csButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }
    }
}
