using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_V4
{
    public partial class Form1 : Form
    {
        private readonly Robot Robot;
        public Form1()
        {
            this.InitializeComponent();
            this.Robot = new Robot(0, 0, this.RefreshNumbers);
            this.RefreshNumbers();
        }

        public void RefreshNumbers()
        {
            int tmp = this.Robot.GetLocation();
            this.number1.Text = (tmp - 2).ToString();
            this.number2.Text = (this.Robot.GetLocation() - 1).ToString();
            this.number3.Text = this.Robot.GetLocation().ToString();
            this.number4.Text = (this.Robot.GetLocation() + 1).ToString();
            this.number5.Text = (this.Robot.GetLocation() + 2).ToString();
        }

        private void Btn_moveOne_Click(object sender, EventArgs e)
        {
            this.Robot.MoveOne();
        }

        private void Btn_leftdir_Click(object sender, EventArgs e)
        {
            this.Robot.SetDirection(-1);
        }

        private void Btn_nodir_Click(object sender, EventArgs e)
        {
            this.Robot.SetDirection(0);
        }

        private void Btn_rightdir_Click(object sender, EventArgs e)
        {
            this.Robot.SetDirection(1);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBox1.Text, out int result))
                this.Robot.GoTo(Convert.ToInt32(this.textBox1.Text));
        }
    }
}
