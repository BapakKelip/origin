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
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "RestoranBk" && password.Text =="Restoran")
            {
                new FormMenu().Show();
                this.Hide();
            }else if (email.Text == "" && password.Text == "")
            {
                MessageBox.Show("Form ini ga boleh kosong");
            } else 
            {
                MessageBox.Show("Nama atau password salah");
            }
        }
    }
}
