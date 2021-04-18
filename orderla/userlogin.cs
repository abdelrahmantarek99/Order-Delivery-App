using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderla
{
    public partial class userlogin : UserControl
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            success s = new success();
            s.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newacc1 na = new newacc1();
            Controls.Add(na);
            na.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lost lo = new lost();
            Controls.Add(lo);
            lo.BringToFront();
        }
    }
}
