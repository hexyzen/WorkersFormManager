
using Guna.UI2.WinForms;

namespace WorkersFormsManager
{
    partial class Worker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worker));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WorkerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkersDOB = new System.Windows.Forms.DateTimePicker();
            this.WorkerSeatCb = new MaterialSkin.Controls.MaterialComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WorkerPhoneTb = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkerAddressTb = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkerNameTb = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerIdTb = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Worker Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.WorkerDGV);
            this.panel1.Controls.Add(this.materialButton4);
            this.panel1.Controls.Add(this.materialButton3);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.WorkersDOB);
            this.panel1.Controls.Add(this.WorkerSeatCb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WorkerPhoneTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WorkerAddressTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WorkerNameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WorkerIdTb);
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 559);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // WorkerDGV
            // 
            this.WorkerDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.WorkerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WorkerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerDGV.BackgroundColor = System.Drawing.Color.White;
            this.WorkerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WorkerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WorkerDGV.ColumnHeadersHeight = 25;
            this.WorkerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.WorkerDGV.EnableHeadersVisualStyles = false;
            this.WorkerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.WorkerDGV.Location = new System.Drawing.Point(535, 15);
            this.WorkerDGV.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerDGV.Name = "WorkerDGV";
            this.WorkerDGV.RowHeadersVisible = false;
            this.WorkerDGV.RowHeadersWidth = 51;
            this.WorkerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkerDGV.Size = new System.Drawing.Size(808, 522);
            this.WorkerDGV.TabIndex = 27;
            //this.WorkerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            //this.WorkerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            //this.WorkerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            //this.WorkerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            //this.WorkerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            //this.WorkerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            //this.WorkerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.WorkerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //this.WorkerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //this.WorkerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            //this.WorkerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            //this.WorkerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //this.WorkerDGV.ThemeStyle.HeaderStyle.Height = 25;
            //this.WorkerDGV.ThemeStyle.ReadOnly = false;
            //this.WorkerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            //this.WorkerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            //this.WorkerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            //this.WorkerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.WorkerDGV.ThemeStyle.RowsStyle.Height = 22;
            //this.WorkerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.WorkerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //// 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.BackColor = System.Drawing.Color.Red;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.FlatAppearance.BorderSize = 0;
            this.materialButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton4.ForeColor = System.Drawing.Color.White;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(391, 471);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(117, 44);
            this.materialButton4.TabIndex = 25;
            this.materialButton4.Text = "Main Page";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = false;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.Red;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.FlatAppearance.BorderSize = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.ForeColor = System.Drawing.Color.White;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(277, 471);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(85, 44);
            this.materialButton3.TabIndex = 24;
            this.materialButton3.Text = "Delete";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.Red;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(159, 471);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(85, 44);
            this.materialButton2.TabIndex = 23;
            this.materialButton2.Text = "Edit";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Red;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(41, 471);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(84, 44);
            this.materialButton1.TabIndex = 22;
            this.materialButton1.Text = "Add";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(331, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date of Birth";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // WorkersDOB
            // 
            this.WorkersDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WorkersDOB.Location = new System.Drawing.Point(262, 324);
            this.WorkersDOB.Margin = new System.Windows.Forms.Padding(4);
            this.WorkersDOB.Name = "WorkersDOB";
            this.WorkersDOB.Size = new System.Drawing.Size(265, 34);
            this.WorkersDOB.TabIndex = 16;
            // 
            // WorkerSeatCb
            // 
            this.WorkerSeatCb.AutoResize = false;
            this.WorkerSeatCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorkerSeatCb.Depth = 0;
            this.WorkerSeatCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WorkerSeatCb.DropDownHeight = 174;
            this.WorkerSeatCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerSeatCb.DropDownWidth = 121;
            this.WorkerSeatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WorkerSeatCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkerSeatCb.FormattingEnabled = true;
            this.WorkerSeatCb.IntegralHeight = false;
            this.WorkerSeatCb.ItemHeight = 43;
            this.WorkerSeatCb.Items.AddRange(new object[] {
            "Manager",
            "Junior Developer",
            "Middle Developer",
            "Senior Developer",
            "Reception"});
            this.WorkerSeatCb.Location = new System.Drawing.Point(277, 162);
            this.WorkerSeatCb.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerSeatCb.MaxDropDownItems = 4;
            this.WorkerSeatCb.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerSeatCb.Name = "WorkerSeatCb";
            this.WorkerSeatCb.Size = new System.Drawing.Size(221, 49);
            this.WorkerSeatCb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(365, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // WorkerPhoneTb
            // 
            this.WorkerPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerPhoneTb.Depth = 0;
            this.WorkerPhoneTb.Font = new System.Drawing.Font("Roboto", 12F);
            this.WorkerPhoneTb.Location = new System.Drawing.Point(21, 324);
            this.WorkerPhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerPhoneTb.MaxLength = 50;
            this.WorkerPhoneTb.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerPhoneTb.Multiline = false;
            this.WorkerPhoneTb.Name = "WorkerPhoneTb";
            this.WorkerPhoneTb.Size = new System.Drawing.Size(223, 50);
            this.WorkerPhoneTb.TabIndex = 12;
            this.WorkerPhoneTb.Text = "";
            this.WorkerPhoneTb.TextChanged += new System.EventHandler(this.materialTextBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // WorkerAddressTb
            // 
            this.WorkerAddressTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerAddressTb.Depth = 0;
            this.WorkerAddressTb.Font = new System.Drawing.Font("Roboto", 12F);
            this.WorkerAddressTb.Location = new System.Drawing.Point(21, 162);
            this.WorkerAddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerAddressTb.MaxLength = 50;
            this.WorkerAddressTb.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerAddressTb.Multiline = false;
            this.WorkerAddressTb.Name = "WorkerAddressTb";
            this.WorkerAddressTb.Size = new System.Drawing.Size(223, 50);
            this.WorkerAddressTb.TabIndex = 10;
            this.WorkerAddressTb.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(313, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Worker Name";
            // 
            // WorkerNameTb
            // 
            this.WorkerNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerNameTb.Depth = 0;
            this.WorkerNameTb.Font = new System.Drawing.Font("Roboto", 12F);
            this.WorkerNameTb.Location = new System.Drawing.Point(277, 47);
            this.WorkerNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerNameTb.MaxLength = 50;
            this.WorkerNameTb.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerNameTb.Multiline = false;
            this.WorkerNameTb.Name = "WorkerNameTb";
            this.WorkerNameTb.Size = new System.Drawing.Size(223, 50);
            this.WorkerNameTb.TabIndex = 8;
            this.WorkerNameTb.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Worker ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WorkerIdTb
            // 
            this.WorkerIdTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerIdTb.Depth = 0;
            this.WorkerIdTb.Font = new System.Drawing.Font("Roboto", 12F);
            this.WorkerIdTb.Location = new System.Drawing.Point(21, 47);
            this.WorkerIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerIdTb.MaxLength = 50;
            this.WorkerIdTb.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerIdTb.Multiline = false;
            this.WorkerIdTb.Name = "WorkerIdTb";
            this.WorkerIdTb.Size = new System.Drawing.Size(223, 50);
            this.WorkerIdTb.TabIndex = 6;
            this.WorkerIdTb.Text = "";
            this.WorkerIdTb.TextChanged += new System.EventHandler(this.WorkerIdTb_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(1308, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1359, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.Worker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox WorkerPhoneTb;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox WorkerAddressTb;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox WorkerNameTb;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox WorkerIdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker WorkersDOB;
        private MaterialSkin.Controls.MaterialComboBox WorkerSeatCb;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView WorkerDGV;
    }
}