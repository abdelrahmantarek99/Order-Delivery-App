using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
            InitializeComponent();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
       
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {

            userlogin us=new userlogin();
            Controls.Add(us);
            us.BringToFront();
     
        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            userlogin2 us2 = new userlogin2();
            Controls.Add(us2);
            us2.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userform us = new userform(false);
            us.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userform us = new userform(false);
            us.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminform af = new adminform();
            af.ShowDialog();
        }
    }
}
