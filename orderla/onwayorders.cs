using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace orderla
{
    public partial class onwayorders : UserControl
    {
        int i2 = 0, incr = 0;
        Label[] timer_label = new Label[6];
        Label[] prand_name_label = new Label[6];
        Label[] date_label = new Label[6];
        public int total_min = 0, total_sec = 0;
        public int[] total_min_arr = new int[6];
        public int[] total_sec_arr = new int[6];
        public bool[] is_not_finished = new bool[10];
        public PictureBox[] timer_pic = new PictureBox[6];
        public string done_pic_loc = "E:/a/done.png";
        public string[] prand_name_string = new string[6];
        public string[] date_string = new string[6];
        public string[] prand_location = new string[6];

        private void clock(int i)
        { ///clock_fn is called every second 

            ///add controls
            this.Controls.Add(this.timer_label[i]);
            this.Controls.Add(this.prand_name_label[i]);
            this.Controls.Add(this.date_label[i]);

            if (is_not_finished[i] == false)
            {
                ///timer_pic[i].Hide();
                //label[i].Hide();
                timer_label[i].Text = "DONE ! :)";
                prand_name_label[i].Text = "NONE";
                date_label[i].Text = "NONE";
                timer_pic[i].ImageLocation = done_pic_loc;

            }
            else
            {
                bool ok = false;
                if (total_min_arr[i] == 0 && total_sec_arr[i] == 1)
                {
                    //label[i].Hide();
                    //timer_pic[i].Hide();
                    timer_label[i].Text = "DONE ! :)";
                    timer_pic[i].ImageLocation = done_pic_loc;
                    prand_name_label[i].Text = "NONE";
                    date_label[i].Text = "NONE";

                    ok = true; is_not_finished[i] = false;
                }

                if (total_sec_arr[i] == 0) { total_sec_arr[i] = 59; total_min_arr[i]--; }
                if (ok == false)
                {
                    timer_label[i].Text = total_min_arr[i] + " : " + total_sec_arr[i];
                    ///timer_pic[i].ImageLocation = done_pic_loc;
                    prand_name_label[i].Text = prand_name_string[i];
                    date_label[i].Text = date_string[i];
                    timer_pic[i].ImageLocation = prand_location[i];
                }

                total_sec_arr[i]--;
            }

        }

        private void pending()
        {
            string mycon = "datasource=localhost;port=3306;username=root;password=حقخلقشةةثقاشؤنثق";
            string query = "select *from abdo.timer  where id='" + 6 + "' ;";
            MySqlConnection con = new MySqlConnection(mycon);

            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();

            DateTime now_time = DateTime.Now;
            DateTime end_timee = now_time.AddMinutes(5);

            for (int y = 0; y < 6; y++)
                is_not_finished[y] = false;


            int i = 0;
            while (myreader.Read())
            {
                DateTime endd = DateTime.Parse(myreader.GetString("end_time"));
                TimeSpan diff = endd.Subtract(now_time);
                total_min = ((diff.Days * 24 * 60) + (diff.Hours * 60) + diff.Minutes);
                if ((total_min > 0 || diff.Seconds > 0) && total_min < 5)
                {
                    is_not_finished[i] = true;
                    total_min_arr[i] = total_min;
                    total_sec_arr[i] = diff.Seconds;
                    prand_name_string[i] = myreader.GetString("prand_name");
                    prand_location[i] = myreader.GetString("location");
                    date_string[i] = myreader.GetString("end_time");
                    i++;
                    if (i == 5) break;
                }

            }
            con.Close();
            myreader.Close();
        }

        private void declare()
        {
            int y = 55;
            ///to declare timer component
            for (int i = 0; i < 6; i++)
            {///timer
                timer_label[i] = new Label();
                timer_label[i].Location = new Point(128, y);
                timer_label[i].Name = string.Concat("label_1", i.ToString());
                timer_label[i].Size = new Size(174, 25);
                timer_label[i].Text = string.Empty;
                timer_label[i].Visible = true;
                timer_label[i].BorderStyle = BorderStyle.FixedSingle;
                timer_label[i].Tag = i;
                timer_label[i].AutoSize = true;
                timer_label[i].Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style);
                ////prand_name
                prand_name_label[i] = new Label();
                prand_name_label[i].Location = new Point(250, y);
                prand_name_label[i].Name = string.Concat("label_2", i.ToString());
                prand_name_label[i].Size = new Size(174, 25);
                prand_name_label[i].Text = string.Empty;
                prand_name_label[i].Visible = true;
                prand_name_label[i].BorderStyle = BorderStyle.FixedSingle;
                prand_name_label[i].Tag = i;
                prand_name_label[i].AutoSize = true;
                prand_name_label[i].Font = new Font(label2.Font.Name, label2.Font.Size, label2.Font.Style);
                ////date
                date_label[i] = new Label();
                date_label[i].Location = new Point(350, y);
                date_label[i].Name = string.Concat("label_2", i.ToString());
                date_label[i].Size = new Size(174, 25);
                date_label[i].Text = string.Empty;
                date_label[i].Visible = true;
                date_label[i].BorderStyle = BorderStyle.FixedSingle;
                date_label[i].Tag = i;
                date_label[i].AutoSize = true;
                date_label[i].Font = new Font(label2.Font.Name, label2.Font.Size, label2.Font.Style);
                y += 62;
            }
            ///picture
            timer_pic[0] = pictureBox1;
            timer_pic[1] = pictureBox2;
            timer_pic[2] = pictureBox3;
            timer_pic[3] = pictureBox4;
            timer_pic[4] = pictureBox5;
        }

        public onwayorders()
        {
            InitializeComponent();
            declare();

            for (int i = 0; i < 5; i++)
            {
                timer_pic[i].Show();
                date_label[i].Show();
                prand_name_label[i].Show();
                timer_label[i].Show();

            }
            label1.Hide();
            pending();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pending();
            clock(0); 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pending();
            clock(1); 
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pending();
            clock(2); 
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pending();
            clock(3); 
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pending();
            clock(4); 
        }
    }
}
