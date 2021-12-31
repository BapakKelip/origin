using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Sederhana
{
    public partial class ayamgeprek : Form
    {
        public ayamgeprek()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }
    }
}
