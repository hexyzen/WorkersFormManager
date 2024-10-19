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
    public partial class ViewWorkers : Form
    {
        public ViewWorkers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files (x86)\Roman Kostiuk\Worker Manager\WorkerDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void WorkerData()
        {
            Con.Open();
            string query = "select * from Worker where WorkerID = '" + WorkerIdTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkIdlbl.Text = dr["WorkerId"].ToString();
                WorkNamelbl.Text = dr["WorkerName"].ToString();
                WorkAddlbl.Text = dr["WorkerAddress"].ToString();
                WorkSeatlbl.Text = dr["WorkerSeat"].ToString();
                WorkPhonelbl.Text = dr["WorkerPhone"].ToString();
                WorkDoblbl.Text = dr["WorkerDOB"].ToString();
                WorkIdlbl.Visible = true;
                WorkNamelbl.Visible = true;
                WorkAddlbl.Visible = true;
                WorkSeatlbl.Visible = true;
                WorkPhonelbl.Visible = true;
                WorkDoblbl.Visible = true;
            }
            Con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                   
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewWorkers_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Home home = new Home(isAdmin: true);
            home.Show();
            this.Hide();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            WorkerData();
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
            e.Graphics.DrawString("======= WORKERS SUMMARY ======= ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(180));
            e.Graphics.DrawString("Worker ID:" + WorkerIdTb.Text+"\tName:" + WorkNamelbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10,100));
            e.Graphics.DrawString("Address:" + WorkAddlbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10,140));
            e.Graphics.DrawString("Seat:" + WorkSeatlbl.Text + "\tDate of birth:" + WorkDoblbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10,180));
            e.Graphics.DrawString("Phone:" + WorkPhonelbl.Text, new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(10,220));
            e.Graphics.DrawString("======= HEXYZEN ======= ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180,280));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
