namespace POS_System
{
    partial class Add_and_Edit_User
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            panel4 = new Panel();
            label5 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(153, 40);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label2.Location = new Point(54, 97);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter username";
            textBox1.Size = new Size(339, 22);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(450, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 16F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(427, 417);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 16F);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(583, 417);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 13;
            button2.Text = "Save User";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(54, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 41);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(54, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 41);
            panel2.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(12, 9);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter password";
            textBox2.Size = new Size(339, 22);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label3.Location = new Point(54, 175);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label4.Location = new Point(54, 255);
            label4.Name = "label4";
            label4.Size = new Size(50, 24);
            label4.TabIndex = 17;
            label4.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Store Manager", "Assistant Store Manager", "Department Supervisor / Section Head", "HR Staff / Admin Staff", "Inventory Supervisor", "Customer Service Supervisor", "Cashier", "Sales Associate / Sales Clerk", "Stock Clerk / Replenisher", "Warehouse Staff", "Delivery Staff", "Bagger", "Janitor / Cleaner", "Security Guard" });
            comboBox1.Location = new Point(12, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 29);
            comboBox1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(54, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 41);
            panel3.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Trebuchet MS", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBox2.Location = new Point(12, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(339, 30);
            comboBox2.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(comboBox2);
            panel4.Location = new Point(54, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 41);
            panel4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold);
            label5.Location = new Point(54, 339);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 22;
            label5.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(722, 9);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 24;
            label10.Text = " X ";
            label10.Click += label10_Click;
            // 
            // Add_and_Edit_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(762, 494);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_and_Edit_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_and_Edit_User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Panel panel3;
        private ComboBox comboBox2;
        private Panel panel4;
        private Label label5;
        private Label label10;
    }
}