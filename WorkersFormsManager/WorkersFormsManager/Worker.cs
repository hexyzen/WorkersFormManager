using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkersFormsManager
{
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files (x86)\Hexyzen\Worker_Manager\WorkerDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                    string query = "insert into WorkerTbl values('" + WorkerIdTb.Text + "','" + WorkerNameTb.Text + "','" + WorkerAddressTb.Text + "','" + WorkerSeatCb.SelectedItem.ToString() + "','" + WorkersDOB.Value.Date + "','" + WorkerPhoneTb.Text + "','" + WorkerEduCb.SelectedItem.ToString() + "', '"+WorkerGenderCb.SelectedItem.ToString()+"')";
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
            string query = "select * from WorkerTbl";
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
                    string query = "delete from WorkerTbl where WorkerId='" + WorkerIdTb.Text + "';";
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
            WorkerEduCb.Text = WorkerDGV.SelectedRows[0].Cells[6].Value.ToString();
            WorkerSeatCb.Text = WorkerDGV.SelectedRows[0].Cells[3].Value.ToString();
            WorkerPhoneTb.Text = WorkerDGV.SelectedRows[0].Cells[5].Value.ToString();
            WorkerGenderCb.Text = WorkerDGV.SelectedRows[0].Cells[7].Value.ToString();

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
                    string query = "update WorkerTbl set WorkerName='" +WorkerNameTb.Text+ "', WorkerAddress = '" + WorkerAddressTb.Text + "',WorkerSeat = '" + WorkerSeatCb.SelectedItem.ToString() + "', WorkerDOB = '" + WorkersDOB.Value.Date + "', WorkerPhone = '" + WorkerPhoneTb.Text + "',WorkerEdu = '" + WorkerEduCb.SelectedItem.ToString() + "', WorkerGen = '" + WorkerGenderCb.SelectedItem.ToString() + "' where WorkerId='" +WorkerIdTb.Text+"';";
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
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
