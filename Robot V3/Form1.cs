using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Robot_V3
{
    public partial class Form1 : Form
    {
        private Robot Robot;
        public Form1()
        {
            this.Robot = new Robot(0, 0);
            InitializeComponent();
            RefreshNumbers();
        }

        public void RefreshNumbers()
        {
            this.label1.Text = (Robot.Plaats - 2).ToString();
            this.label2.Text = (Robot.Plaats - 1).ToString();
            this.label3.Text = (Robot.Plaats).ToString();
            this.label4.Text = (Robot.Plaats + 1).ToString();
            this.label5.Text = (Robot.Plaats + 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Robot.Richting = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Robot.Richting = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Robot.Richting = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Robot.ZetEenStap();
            RefreshNumbers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Robot.GaNaar(Convert.ToInt32(this.textBox1.Text));
        }
    }
}
