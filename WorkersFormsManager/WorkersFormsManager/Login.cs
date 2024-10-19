using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // Capture the entered UserId
            string enteredId = UserIdTb.Text;

            if (enteredId == "admin")
            {
                // If it's admin, show the regular Home form
                this.Hide();
                Home home = new Home(isAdmin: true);
                home.Show();
            }
            else
            {
                // Check if the entered ID exists in the database
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files (x86)\Roman Kostiuk\Worker Manager\WorkerDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Worker WHERE WorkerId = @WorkerId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@WorkerId", enteredId);

                    int workerCount = (int)cmd.ExecuteScalar();

                    if (workerCount > 0)
                    {
                        // If the worker ID exists, show a limited Home form (with only Tasks visible)
                        this.Hide();
                        Home home = new Home(isAdmin: false);
                        home.Show();
                    }
                    else
                    {
                        // If neither admin nor worker ID is valid
                        MessageBox.Show("Invalid User ID");
                    }
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            UserIdTb.Clear();
            PasswordTb.Clear();
        }
    }
}
