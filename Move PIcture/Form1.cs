using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_PIcture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X > 0)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
            }
        }

       private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y-10);
        }

        private async void Button4_Click(object sender, EventArgs e)
        {
           if(pictureBox2.Location.X + 5 < ClientRectangle.Width - pictureBox2.Width)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
                await Task.Delay(500);
                pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
                await Task.Delay(500);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y+10);
        }
    }
    
}
