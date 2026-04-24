namespace WinFormsApp4
{
    partial class ProductManagement
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
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            button7 = new Button();
            label3 = new Label();
            label10 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(33, 90);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 33);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 9);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 16);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(619, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 6;
            button1.Text = "+ Add Product";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Filter", "" });
            comboBox1.Location = new Point(8, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(70, 26);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Filter";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(353, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 33);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 376);
            dataGridView1.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(319, 531);
            button3.Name = "button3";
            button3.Size = new Size(36, 30);
            button3.TabIndex = 12;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(361, 531);
            button4.Name = "button4";
            button4.Size = new Size(36, 30);
            button4.TabIndex = 13;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(403, 531);
            button5.Name = "button5";
            button5.Size = new Size(36, 30);
            button5.TabIndex = 14;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(445, 531);
            button6.Name = "button6";
            button6.Size = new Size(36, 30);
            button6.TabIndex = 15;
            button6.Text = "10";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(277, 531);
            button2.Name = "button2";
            button2.Size = new Size(36, 30);
            button2.TabIndex = 20;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.WhiteSmoke;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(487, 531);
            button7.Name = "button7";
            button7.Size = new Size(36, 30);
            button7.TabIndex = 21;
            button7.Text = ">";
            button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(33, 37);
            label3.Name = "label3";
            label3.Size = new Size(149, 40);
            label3.TabIndex = 22;
            label3.Text = "Products";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(773, 9);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 23;
            label10.Text = " X ";
            label10.Click += label10_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 573);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PManagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button2;
        private Button button7;
        private Label label3;
        private Label label10;
    }
}