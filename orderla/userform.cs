using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace orderla
{
    public partial class userform : Form
    {
       

        public userform(bool flag)
        {
            if (flag == true)
            {
                this.Close();
            }
            InitializeComponent();
            userhome1.Visible = true;
            useracc1.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            onwayorders1.Visible = false;
            sponsers1.Visible = false;
            contactus1.Visible = false;
            bestsell1.Visible = false;
            feedback1.Visible = false;
            doneorders1.Visible = false;
            usercategories1.Visible = false;



        }

        //userform Load
        private void userform_Load(object sender, EventArgs e)
        {
            menu.ForeColor = Color.White;
            userhome1.Visible = true;
            useracc1.Visible = false;
            panel9.Visible = false;
            panel1.Visible = false;
            onwayorders1.Visible = false;
            sponsers1.Visible = false;
            contactus1.Visible = false;
            bestsell1.Visible = false;
            doneorders1.Visible = false;
            feedback1.Visible = false;
            usercategories1.Visible = false;
        }

    

        //exit panel clicked
        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimize panel clicked
        private void panel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        //home button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel9);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.ShowSync(userhome1);




            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }

        //menu button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition1.ShowSync(panel9);
            bunifuTransition2.ShowSync(panel1);




            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }
        
        //account button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(panel9);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.ShowSync(useracc1);

            //----------------------------------------------colors----------------------------------------------------------------------------
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
        }


        //onway button
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.ShowSync(onwayorders1);

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.ShowSync(sponsers1);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.ShowSync(contactus1);

        }

        private void contactus1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.ShowSync(bestsell1);

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.ShowSync(feedback1);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //done order
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(usercategories1);

            bunifuTransition2.ShowSync(doneorders1);


        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(userhome1);
            bunifuTransition2.HideSync(useracc1);
            bunifuTransition2.HideSync(onwayorders1);
            bunifuTransition2.HideSync(panel1);
            bunifuTransition2.HideSync(sponsers1);
            bunifuTransition2.HideSync(contactus1);
            bunifuTransition2.HideSync(bestsell1);
            bunifuTransition2.HideSync(feedback1);
            bunifuTransition2.HideSync(doneorders1);
            bunifuTransition2.ShowSync(usercategories1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
