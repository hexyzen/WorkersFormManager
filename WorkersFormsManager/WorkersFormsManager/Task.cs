using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkersFormsManager
{
    public partial class Task : Form
    {
        private bool isAdmin;

        public Task(bool isAdmin)
        {
                this.isAdmin = isAdmin;
                InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files (x86)\Roman Kostiuk\Worker Manager\WorkerDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (TaskNameTb.Text == "" || WorkerIdTb.Text == "" || TaskDescriptionTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO Tasks (WorkerId, Name, Description, CreationDate) VALUES (@WorkerId, @Name, @Description, @CreationDate)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@WorkerId", WorkerIdTb.Text);
                        cmd.Parameters.AddWithValue("@Name", TaskNameTb.Text);
                        cmd.Parameters.AddWithValue("@Description", TaskDescriptionTb.Text);
                        cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Task Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WorkerGenderTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Tasks";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            WorkerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Worker_Load(object sender, EventArgs e)
        {
            populate();
        }



        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (TaskIdTb.Text == "")

            {
                MessageBox.Show("Enter task Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Tasks where Id='" + TaskIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Worker deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }


        private void WorkerIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TaskIdTb.Text = WorkerDGV.SelectedRows[0].Cells[0].Value.ToString();
            WorkerIdTb.Text = WorkerDGV.SelectedRows[0].Cells[1].Value.ToString();
            TaskNameTb.Text = WorkerDGV.SelectedRows[0].Cells[2].Value.ToString();
            TaskDescriptionTb.Text = WorkerDGV.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (TaskIdTb.Text == "" || TaskNameTb.Text == "" || WorkerIdTb.Text == "" || TaskDescriptionTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Tasks set Name='" + TaskNameTb.Text + "', Description = '" + TaskDescriptionTb.Text + "', WorkerId = '" + WorkerIdTb.Text + "' where Id='" + TaskIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Home home = new Home(isAdmin: isAdmin);
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WorkerDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
