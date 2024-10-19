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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files (x86)\Roman Kostiuk\Worker Manager\WorkerDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void WorkerData()
        {
            if (WorkerIdTb.Text == "")
            {
                MessageBox.Show("Enter worker`s Id");
            }
            else
            {
                Con.Open();
                string query = "select * from Worker where WorkerID = '" + WorkerIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dataTable);
                foreach (DataRow dr in dataTable.Rows)
                {

                    WorkerNameTb.Text = dr["WorkerName"].ToString();
                    WorkerSeatTb.Text = dr["WorkerSeat"].ToString();
                    WorkerNameTb.Visible = true;
                    WorkerSeatTb.Visible = true;
                }
                Con.Close();
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WorkerSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Home home = new Home(isAdmin: true);
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            WorkerData();
        }
        int Hourlybase;
        int total;
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (WorkerSeatTb.Text == "")
            {
                MessageBox.Show("Select an Worker");
            }
            else if (WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 200)
            {
                MessageBox.Show("Enter a valid number of hours(<200)");
            }
            else
            {
                if (WorkerSeatTb.Text == "Manager")
                {
                    Hourlybase = 35;
                } else if (WorkerSeatTb.Text == "Senior Developer")
                {
                    Hourlybase = 30;
                }
                else if (WorkerSeatTb.Text == "Middle Developer")
                {
                    Hourlybase = 20;
                }
                else if (WorkerSeatTb.Text == "Junior Developer")
                {
                    Hourlybase = 10;
                }
                else if (WorkerSeatTb.Text == "Reception")
                {
                    Hourlybase = 7;
                }
                else
                {
                    Hourlybase = 5;
                }
                total = Hourlybase * Convert.ToInt32(WorkedTb.Text);
                WorkerSalary.Text = "Worker ID: " + WorkerIdTb.Text + "\n" + "Name: " + WorkerNameTb.Text + "\n" + "Seat: " + WorkerSeatTb.Text + "\n" + "Hours Worked: " + WorkedTb.Text + "\n" + "Hourly Salary: " + Hourlybase + "\n" + "Total amount: " + total;
                
            }          
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("======= SALARY SUMMARY ======= ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(180));
            e.Graphics.DrawString("Worker ID:" + WorkerIdTb.Text , new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("Name:" + WorkerNameTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString("Seat:" + WorkerSeatTb.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Hourly Pay:" + Hourlybase, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("Total salary:" + total, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10, 260));
            e.Graphics.DrawString("======= HEXYZEN ======= ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180, 320));
        }

        private void WorkerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkerIdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
