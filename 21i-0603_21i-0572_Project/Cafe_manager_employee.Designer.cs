namespace WinFormsApp1
{
    partial class Cafe_manager_employee
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            back_button2 = new Button();
            lname_textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            fname_textBox2 = new TextBox();
            add = new Label();
            email_textBox1 = new TextBox();
            label3 = new Label();
            phonenum_textBox2 = new TextBox();
            label4 = new Label();
            password_textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            role_comboBox1 = new ComboBox();
            Add_button = new Button();
            label7 = new Label();
            hours_textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 737);
            panel1.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(77, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(508, 50);
            textBox3.TabIndex = 53;
            textBox3.Text = "EMPLOYEE INFORMATION";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(185, 90);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(801, 290);
            dataGridView2.TabIndex = 60;
            // 
            // back_button2
            // 
            back_button2.BackColor = Color.Black;
            back_button2.FlatAppearance.BorderSize = 0;
            back_button2.FlatStyle = FlatStyle.Flat;
            back_button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            back_button2.ForeColor = Color.White;
            back_button2.Location = new Point(92, 687);
            back_button2.Name = "back_button2";
            back_button2.Size = new Size(149, 35);
            back_button2.TabIndex = 63;
            back_button2.Text = " << Go Back";
            back_button2.UseVisualStyleBackColor = false;
            back_button2.Click += back_button2_Click;
            // 
            // lname_textBox1
            // 
            lname_textBox1.Location = new Point(348, 520);
            lname_textBox1.Name = "lname_textBox1";
            lname_textBox1.Size = new Size(237, 27);
            lname_textBox1.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(164, 511);
            label2.Name = "label2";
            label2.Size = new Size(164, 34);
            label2.TabIndex = 74;
            label2.Text = "last name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(164, 456);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 73;
            label1.Text = "first name: ";
            // 
            // fname_textBox2
            // 
            fname_textBox2.Location = new Point(348, 463);
            fname_textBox2.Name = "fname_textBox2";
            fname_textBox2.Size = new Size(237, 27);
            fname_textBox2.TabIndex = 72;
            // 
            // add
            // 
            add.AutoSize = true;
            add.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            add.ForeColor = Color.Black;
            add.Location = new Point(110, 402);
            add.Name = "add";
            add.Size = new Size(312, 37);
            add.TabIndex = 71;
            add.Text = "Add new employee:";
            // 
            // email_textBox1
            // 
            email_textBox1.Location = new Point(814, 465);
            email_textBox1.Name = "email_textBox1";
            email_textBox1.Size = new Size(237, 27);
            email_textBox1.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(684, 456);
            label3.Name = "label3";
            label3.Size = new Size(98, 34);
            label3.TabIndex = 76;
            label3.Text = "email:";
            // 
            // phonenum_textBox2
            // 
            phonenum_textBox2.Location = new Point(348, 575);
            phonenum_textBox2.Name = "phonenum_textBox2";
            phonenum_textBox2.Size = new Size(237, 27);
            phonenum_textBox2.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(92, 566);
            label4.Name = "label4";
            label4.Size = new Size(224, 34);
            label4.TabIndex = 78;
            label4.Text = "phone number:";
            // 
            // password_textBox4
            // 
            password_textBox4.Location = new Point(814, 518);
            password_textBox4.Name = "password_textBox4";
            password_textBox4.Size = new Size(237, 27);
            password_textBox4.TabIndex = 81;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(630, 509);
            label5.Name = "label5";
            label5.Size = new Size(151, 34);
            label5.TabIndex = 80;
            label5.Text = "password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(709, 566);
            label6.Name = "label6";
            label6.Size = new Size(72, 34);
            label6.TabIndex = 82;
            label6.Text = "role:";
            // 
            // role_comboBox1
            // 
            role_comboBox1.FormattingEnabled = true;
            role_comboBox1.Items.AddRange(new object[] { "employee", "cashier", "cook" });
            role_comboBox1.Location = new Point(815, 572);
            role_comboBox1.Name = "role_comboBox1";
            role_comboBox1.Size = new Size(236, 28);
            role_comboBox1.TabIndex = 83;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.FromArgb(0, 0, 64);
            Add_button.FlatAppearance.BorderSize = 0;
            Add_button.FlatStyle = FlatStyle.Flat;
            Add_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Add_button.ForeColor = Color.White;
            Add_button.Location = new Point(948, 623);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(103, 35);
            Add_button.TabIndex = 84;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(115, 619);
            label7.Name = "label7";
            label7.Size = new Size(201, 34);
            label7.TabIndex = 85;
            label7.Text = "hours to work:";
            // 
            // hours_textBox1
            // 
            hours_textBox1.Location = new Point(348, 626);
            hours_textBox1.Name = "hours_textBox1";
            hours_textBox1.Size = new Size(237, 27);
            hours_textBox1.TabIndex = 86;
            // 
            // Cafe_manager_employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 737);
            Controls.Add(hours_textBox1);
            Controls.Add(label7);
            Controls.Add(Add_button);
            Controls.Add(role_comboBox1);
            Controls.Add(label6);
            Controls.Add(password_textBox4);
            Controls.Add(label5);
            Controls.Add(phonenum_textBox2);
            Controls.Add(label4);
            Controls.Add(email_textBox1);
            Controls.Add(label3);
            Controls.Add(lname_textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fname_textBox2);
            Controls.Add(add);
            Controls.Add(back_button2);
            Controls.Add(dataGridView2);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Name = "Cafe_manager_employee";
            Text = "Cafe_manager_employee";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private DataGridView dataGridView2;
        private Button back_button2;
        private TextBox lname_textBox1;
        private Label label2;
        private Label label1;
        private TextBox fname_textBox2;
        private Label add;
        private TextBox email_textBox1;
        private Label label3;
        private TextBox phonenum_textBox2;
        private Label label4;
        private TextBox password_textBox4;
        private Label label5;
        private Label label6;
        private ComboBox role_comboBox1;
        private Button Add_button;
        private Label label7;
        private TextBox hours_textBox1;
    }



}