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
    public partial class useracc : UserControl
    {
        bool flag = false;
        public useracc()
        {
            InitializeComponent();
            settingpanel.Visible = false;
            userinfopanel.Visible = false;
        }

        //form loading
        private void useracc_Load(object sender, EventArgs e)
        {
            settingpanel.Visible = false;
            userinfopanel.Visible = false;
        }

        //user info button clicked
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            userinfopanel.Visible = true;
            settingpanel.Visible = false;
        }

        //setting button clicked
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            userinfopanel.Visible = false;
            settingpanel.Visible = true;
        }

        //orders history button clicked
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            userinfopanel.Visible = false;
            settingpanel.Visible = false;
            flag = true;
            this.Hide();
            userform pop = new userform(flag);
            pop.Show();
           
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

// buttons & labels & panels list


//-------------------------------------------------------
//1) user info button bifta7 panel asmha (userinfopanel)
//2) fe el userinfopanel :
//                       A) username = label3
//                       B) email =  label4
//                       c) phone number = label5
//                       d) credit card =  label6
//                       e) visa number = label7
//---------------------------------------------------------
//