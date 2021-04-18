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
    public partial class newacc1 : UserControl
    {
        public newacc1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newacc2 na2 = new newacc2();
            Controls.Add(na2);
            na2.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
