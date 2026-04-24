namespace Point_Of_Sale
{
    partial class UserManagement
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
            dataGridView1 = new DataGridView();
            btnAddUser = new Button();
            label3 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 156);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(821, 466);
            dataGridView1.TabIndex = 22;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = SystemColors.Highlight;
            btnAddUser.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(736, 50);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(124, 42);
            btnAddUser.TabIndex = 21;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(39, 50);
            label3.Name = "label3";
            label3.Size = new Size(99, 40);
            label3.TabIndex = 20;
            label3.Text = "Users";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(852, 9);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 23;
            label10.Text = " X ";
            label10.Click += label10_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 664);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddUser);
            Controls.Add(label3);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserManagement";
            Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddUser;
        private Label label3;
        private Label label10;
    }
}