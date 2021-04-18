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
    public partial class usercategories3 : UserControl
    {
        public string selected_food_name, selected_prand_name, description;
        public int cost = 0, total_min = 0, quantity = 0;
        public bool changedd = false;
        public usercategories3(string selected, string selected2)
        {
            InitializeComponent();
            this.selected_food_name = selected;
            this.selected_prand_name = selected2;

            show_description();
        }
        private void show_description()
        {
            try
            {
                string mycon = "datasource=localhost;port=3306;username=root;password=حقخلقشةةثقاشؤنثق";

                string query = "select *from orderla.myorders where food_name='" + selected_food_name + "' ;";
                MySqlConnection con = new MySqlConnection(mycon);
                MySqlDataReader myreader2;
                MySqlCommand command = new MySqlCommand(query, con);

                con.Open();
                myreader2 = command.ExecuteReader();

                while (myreader2.Read())
                {
                    cost = myreader2.GetInt32("cost");
                    pictureBox1.ImageLocation = myreader2.GetString("location");
                    cost_label.Text = cost.ToString();
                    description_label.Text = myreader2.GetString("description");
                    name_label.Text = selected_food_name;
                    brand_label.Text = selected_prand_name;

                }

                //listView1.Items.Remove(listView1.Items[0]);
                //listView1.Items.RemoveAt(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void usercategories3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedd = true;
            quantity = Convert.ToInt32(comboBox1.Text);
            all_cost_label2.Text = Convert.ToString(cost * quantity);
        }
    }
}
