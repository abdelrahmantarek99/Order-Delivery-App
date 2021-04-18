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
    public partial class lost : UserControl
    {
        public lost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            reverse rs = new reverse();
            Controls.Add(rs);
            rs.BringToFront();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
