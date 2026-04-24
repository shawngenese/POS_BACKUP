namespace Point_Of_Sale
{
    partial class CategoryManagement
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
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            btnUsers = new Button();
            btnSalesReports = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnDashboard = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(217, -1);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 96);
            panel3.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(901, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 27);
            label2.TabIndex = 6;
            label2.Text = "Admin";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(858, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(37, 34);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(45, 31);
            label3.Name = "label3";
            label3.Size = new Size(150, 40);
            label3.TabIndex = 33;
            label3.Text = "Category";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnSalesReports);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 702);
            panel1.TabIndex = 33;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 0, 64);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 622);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 66);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(0, 0, 64);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(12, 422);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(196, 66);
            btnUsers.TabIndex = 8;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSalesReports
            // 
            btnSalesReports.BackColor = Color.FromArgb(0, 0, 64);
            btnSalesReports.FlatAppearance.BorderSize = 0;
            btnSalesReports.FlatStyle = FlatStyle.Flat;
            btnSalesReports.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReports.ForeColor = Color.White;
            btnSalesReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalesReports.Location = new Point(12, 348);
            btnSalesReports.Margin = new Padding(3, 4, 3, 4);
            btnSalesReports.Name = "btnSalesReports";
            btnSalesReports.Size = new Size(196, 66);
            btnSalesReports.TabIndex = 7;
            btnSalesReports.Text = "Sales Reports";
            btnSalesReports.UseVisualStyleBackColor = false;
            btnSalesReports.Click += btnSalesReports_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.MediumBlue;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(12, 274);
            btnCategories.Margin = new Padding(3, 4, 3, 4);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(196, 66);
            btnCategories.TabIndex = 6;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(0, 0, 64);
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(12, 200);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(196, 66);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(16, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(37, 34);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 2;
            label1.Text = "POS SYSTEM";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 0, 64);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 126);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(196, 66);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 199);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(929, 466);
            dataGridView1.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1067, 125);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 36;
            button1.Text = "Add Category";
            button1.UseVisualStyleBackColor = false;
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1244, 701);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryManagement";
            StartPosition = FormStartPosition.Manual;
            Text = "CategoryManagement";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Panel panel1;
        private Button btnLogout;
        private Button btnUsers;
        private Button btnSalesReports;
        private Button btnCategories;
        private Button btnProducts;
        private Panel panel2;
        private Label label1;
        private Button btnDashboard;
        private DataGridView dataGridView1;
        private Button button1;
    }
}