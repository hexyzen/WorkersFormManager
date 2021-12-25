using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkersFormsManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (UserIdTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
  
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            UserIdTb.Clear();
            PasswordTb.Clear();
        }
    }
}
