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
    public partial class doneorders : UserControl
    {
        public int i = 0, incr = 0, increament = 0;
        public string[] location = new string[2000];
        public int i2 = 0;

        public doneorders()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            show_my_orders(); 

        }
        public void show_my_orders()
        {
            int total_min;
            string mycon = "datasource=localhost;port=3306;username=root;password=حقخلقشةةثقاشؤنثق";

            string query = "select *from abdo.timer where id='" + 6 + "' ;";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlDataReader myreader2;
            MySqlCommand command = new MySqlCommand(query, con);

            con.Open();
            myreader2 = command.ExecuteReader();

            while (myreader2.Read())
            {
                DateTime now_time = DateTime.Now;
                DateTime endd = DateTime.Parse(myreader2.GetString("end_time"));
                TimeSpan diff = endd.Subtract(now_time);
                total_min = ((diff.Days * 24 * 60) + (diff.Hours * 60) + diff.Minutes);


                if (total_min < 0 || (diff.Seconds <= 0 && total_min == 0))
                {
                    location[i2++] = myreader2.GetString("location");
                    string prand_name = myreader2.GetString("prand_name");
                    string date = myreader2.GetString("end_time");
                    string food_name = myreader2.GetString("food_name");
                    string quantity = myreader2.GetString("quantity");
                    int cost = myreader2.GetInt32("cost");
                    string address = myreader2.GetString("address");
                    imageList1 = new ImageList();
                    imageList1.ImageSize = new Size(100, 100);
                    listView1.LargeImageList = imageList1;
                    listView1.SmallImageList = imageList1;

                    for (int y = 0; y < i2; ++y)
                    {
                        imageList1.Images.Add(Image.FromFile(location[y]));
                    }
                    listView1.Items.Add("", i2 - 1);
                    listView1.Items[incr].SubItems.Add(food_name);
                    listView1.Items[incr].SubItems.Add(prand_name);
                    listView1.Items[incr].SubItems.Add(quantity);
                    listView1.Items[incr].SubItems.Add(cost.ToString());
                    listView1.Items[incr].SubItems.Add(date);
                    listView1.Items[incr].SubItems.Add(address);

                    incr++;
                }

                //listView1.Items.Remove(listView1.Items[0]);
                //listView1.Items.RemoveAt(0);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
