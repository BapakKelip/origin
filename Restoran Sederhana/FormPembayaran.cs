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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }
    }
}
