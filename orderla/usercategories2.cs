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
    public partial class usercategories2 : UserControl
    {
        public string selected_prand_name;
        public string[] location = new string[2000];
        public int i = 0;

        private void show_food()
        {
            try
            {
                string mycon = "datasource=localhost;port=3306;username=root;password=حقخلقشةةثقاشؤنثق";

                string query = "select *from orderla.myorders where shop_name='" + selected_prand_name + "' ;";
                MySqlConnection con = new MySqlConnection(mycon);
                MySqlDataReader myreader2;
                MySqlCommand command = new MySqlCommand(query, con);

                con.Open();
                myreader2 = command.ExecuteReader();

                while (myreader2.Read())
                {
                    location[i++] = myreader2.GetString("location");
                    string food_name = myreader2.GetString("food_name");
                    imageList2 = new ImageList();
                    imageList2.ImageSize = new Size(100, 100);
                    listView2.LargeImageList = imageList2;
                    listView2.SmallImageList = imageList2;

                    for (int y = 0; y < i; ++y)
                    {
                        imageList2.Images.Add(Image.FromFile(location[y]));
                    }
                    listView2.Items.Add(food_name, i - 1);
                }

                //listView1.Items.Remove(listView1.Items[0]);
                //listView1.Items.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public usercategories2(string selected)
        {
            InitializeComponent();
            this.selected_prand_name = selected;

            show_food();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_food = listView2.SelectedItems[0].SubItems[0].Text;

            Form3 f3 = new Form3(selected_food, selected_prand_name);

            f3.Show();
            this.Hide();
        }
    }
}
