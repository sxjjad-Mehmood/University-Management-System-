using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universitymangementsystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("Enter Both User Name and Password");
            }
            else if (usernametb.Text == "Admin" && passwordtb.Text == "password")
            {
                MessageBox.Show("succefull login");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
                usernametb.Text = "";
                passwordtb.Text = "";
            }
        }

        private void resetlbl_Click(object sender, EventArgs e)
        {
            usernametb.Text = "";
            passwordtb.Text = "";
        }
    }
}
