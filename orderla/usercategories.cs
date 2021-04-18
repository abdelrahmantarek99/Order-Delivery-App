using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace orderla
{
    public partial class usercategories : UserControl
    {
        public usercategories()
        {
            InitializeComponent();
            prands_list();

        }
        private void prands_list()
        {
            int i = 0;
            string[] location = new string[2000];
            string mycon = "datasource=localhost;port=3306;username=root;password=حقخلقشةةثقاشؤنثق";
            string query = "select *from abdo.users_orders  ;";
            MySqlConnection con = new MySqlConnection(mycon);

            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                string prand_name = myreader.GetString("food_name");
                location[i++] = myreader.GetString("location");
                imageList1 = new ImageList();
                imageList1.ImageSize = new Size(100, 100);
                listView1.LargeImageList = imageList1;
                listView1.SmallImageList = imageList1;
                for (int y = 0; y < i; ++y)
                {
                    imageList1.Images.Add(Image.FromFile(location[y]));

                }
                listView1.Items.Add(prand_name, i - 1);

                //listView1.Items[increament++].SubItems.Add(prand_name);

            }
            con.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selected_prand = listView1.SelectedItems[0].SubItems[0].Text;
            Form2 f1 = new Form2(selected_prand);
            f1.Show();
            this.Hide();
        }
    }
}
