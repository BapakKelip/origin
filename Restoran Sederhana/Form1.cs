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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new ayamgeprek().Show();
            this.Hide();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            new FormPembayaran().Show();
            this.Hide();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new FormAbout().Show();
            this.Hide();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            new FormContactUs().Show();
            this.Hide();
        }
    }
}
