using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkersFormsManager
{
    public partial class Worker : Form
    {
        public Worker()
        {
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
            if (WorkerIdTb.Text == "" || WorkerNameTb.Text == "" || WorkerPhoneTb.Text == "" || WorkerAddressTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Worker values('" + WorkerIdTb.Text + "','" + WorkerNameTb.Text + "','" + WorkerAddressTb.Text + "','" + WorkerSeatCb.SelectedItem.ToString() + "','" + WorkersDOB.Value.Date + "','" + WorkerPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Worker Added");
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
            string query = "select * from Worker";
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
            if (WorkerIdTb.Text == "")

            {
                MessageBox.Show("Enter worker Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Worker where WorkerId='" + WorkerIdTb.Text + "';";
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
            WorkerIdTb.Text = WorkerDGV.SelectedRows[0].Cells[0].Value.ToString();
            WorkerNameTb.Text = WorkerDGV.SelectedRows[0].Cells[1].Value.ToString();
            WorkerAddressTb.Text = WorkerDGV.SelectedRows[0].Cells[2].Value.ToString();
            WorkerSeatCb.Text = WorkerDGV.SelectedRows[0].Cells[3].Value.ToString();
            WorkerPhoneTb.Text = WorkerDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (WorkerIdTb.Text == "" || WorkerNameTb.Text == "" || WorkerPhoneTb.Text == "" || WorkerAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            } 
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Worker set WorkerName='" +WorkerNameTb.Text+ "', WorkerAddress = '" + WorkerAddressTb.Text + "',WorkerSeat = '" + WorkerSeatCb.SelectedItem.ToString() + "', WorkerDOB = '" + WorkersDOB.Value.Date + "', WorkerPhone = '" + WorkerPhoneTb.Text + "' where WorkerId='" +WorkerIdTb.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Worker Updated");
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
            Home home = new Home(isAdmin: true);
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
