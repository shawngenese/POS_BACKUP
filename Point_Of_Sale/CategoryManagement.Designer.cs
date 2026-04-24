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
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(30, 48);
            label3.Name = "label3";
            label3.Size = new Size(175, 40);
            label3.TabIndex = 13;
            label3.Text = "Categories";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(727, 48);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 18;
            button1.Text = "Add Category";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(821, 466);
            dataGridView1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(852, 9);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 20;
            label5.Text = " X ";
            label5.Click += label5_Click;
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(892, 664);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
    }
}