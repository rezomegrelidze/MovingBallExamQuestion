using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBallExamQuestion
{
    public partial class Form1 : Form
    {
        private int delta = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void MoveBallDown()
        {
            basketball.Location =
                new Point(basketball.Location.X , basketball.Location.Y + delta);
        }

        private void MoveBallUp()
        {
            basketball.Location =
                new Point(basketball.Location.X , basketball.Location.Y - delta);
        }

        private void MoveBallRight()
        {
            basketball.Location =
                new Point(basketball.Location.X + delta, basketball.Location.Y); ;
        }

        private void MoveBallLeft()
        {
            basketball.Location = 
                new Point(basketball.Location.X - delta,basketball.Location.Y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            if(key == Keys.Right) MoveBallRight();
            else if(key == Keys.Left) MoveBallLeft();
            else if(key == Keys.Up) MoveBallUp();
            else if(key == Keys.Down) MoveBallDown();
        }

        private void upPb_Click(object sender, EventArgs e)
        {
            MoveBallUp();
        }

        private void leftPb_Click(object sender, EventArgs e)
        {
            MoveBallLeft();
        }

        private void rightPb_Click(object sender, EventArgs e)
        {
            MoveBallRight();
        }

        private void downPb_Click(object sender, EventArgs e)
        {
            MoveBallDown();
        }
    }
}
