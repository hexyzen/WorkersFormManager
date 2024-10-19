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
    public partial class Home : Form
    {
        private bool isAdmin;
        public Home(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            // Call the method to adjust visibility based on user role
            AdjustVisibilityBasedOnRole();
        }

        private void AdjustVisibilityBasedOnRole()
        {
            if (!isAdmin)
            {

                label2.Visible = false;     
                pictureBox1.Visible = false;   
                label3.Visible = false;        
                pictureBox2.Visible = false;   
                label4.Visible = false;       
                pictureBox3.Visible = false;    


                label5.Visible = true;
                pictureBox5.Visible = true;
            }
            else
            {
                // If admin, everything is visible by default
                label2.Visible = true;
                pictureBox1.Visible = true;
                label3.Visible = true;
                pictureBox2.Visible = true;
                label4.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
            this.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewWorkers view = new ViewWorkers();
            view.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewWorkers view = new ViewWorkers();
            view.Show();
            this.Hide(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Task task = new Task(isAdmin: isAdmin);
            task.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Task task = new Task(isAdmin: isAdmin);
            task.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
