using System;
using System.Windows.Forms;

namespace LoginWithJsonApp
{
    public partial class Form2 : Form
    {
        private int seconds = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = "Timer: " + seconds + " seconds";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }



}
