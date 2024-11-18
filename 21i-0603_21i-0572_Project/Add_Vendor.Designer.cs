namespace WinFormsApp1
{
    partial class Add_Vendor
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
            textBox2 = new TextBox();
            Add_button = new Button();
            phonenum_textBox2 = new TextBox();
            label4 = new Label();
            email_textBox1 = new TextBox();
            label3 = new Label();
            lname_textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            fname_textBox2 = new TextBox();
            back_button2 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 448);
            panel1.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(88, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 50);
            textBox2.TabIndex = 73;
            textBox2.Text = "ADD VENDOR";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.FromArgb(0, 0, 64);
            Add_button.FlatAppearance.BorderSize = 0;
            Add_button.FlatStyle = FlatStyle.Flat;
            Add_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Add_button.ForeColor = Color.White;
            Add_button.Location = new Point(418, 346);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(103, 35);
            Add_button.TabIndex = 100;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // phonenum_textBox2
            // 
            phonenum_textBox2.Location = new Point(359, 230);
            phonenum_textBox2.Name = "phonenum_textBox2";
            phonenum_textBox2.Size = new Size(237, 27);
            phonenum_textBox2.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(103, 221);
            label4.Name = "label4";
            label4.Size = new Size(224, 34);
            label4.TabIndex = 94;
            label4.Text = "phone number:";
            // 
            // email_textBox1
            // 
            email_textBox1.Location = new Point(359, 288);
            email_textBox1.Name = "email_textBox1";
            email_textBox1.Size = new Size(237, 27);
            email_textBox1.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(229, 279);
            label3.Name = "label3";
            label3.Size = new Size(98, 34);
            label3.TabIndex = 92;
            label3.Text = "email:";
            // 
            // lname_textBox1
            // 
            lname_textBox1.Location = new Point(359, 175);
            lname_textBox1.Name = "lname_textBox1";
            lname_textBox1.Size = new Size(237, 27);
            lname_textBox1.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(175, 166);
            label2.Name = "label2";
            label2.Size = new Size(164, 34);
            label2.TabIndex = 90;
            label2.Text = "last name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(175, 111);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 89;
            label1.Text = "first name: ";
            // 
            // fname_textBox2
            // 
            fname_textBox2.Location = new Point(359, 118);
            fname_textBox2.Name = "fname_textBox2";
            fname_textBox2.Size = new Size(237, 27);
            fname_textBox2.TabIndex = 88;
            // 
            // back_button2
            // 
            back_button2.BackColor = Color.Black;
            back_button2.FlatAppearance.BorderSize = 0;
            back_button2.FlatStyle = FlatStyle.Flat;
            back_button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            back_button2.ForeColor = Color.White;
            back_button2.Location = new Point(88, 390);
            back_button2.Name = "back_button2";
            back_button2.Size = new Size(149, 35);
            back_button2.TabIndex = 101;
            back_button2.Text = " << Go Back";
            back_button2.UseVisualStyleBackColor = false;
            back_button2.Click += back_button2_Click;
            // 
            // Add_Vendor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 448);
            Controls.Add(back_button2);
            Controls.Add(Add_button);
            Controls.Add(phonenum_textBox2);
            Controls.Add(label4);
            Controls.Add(email_textBox1);
            Controls.Add(label3);
            Controls.Add(lname_textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fname_textBox2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Name = "Add_Vendor";
            Text = "Add_Vendor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Button Add_button;
        private TextBox phonenum_textBox2;
        private Label label4;
        private TextBox email_textBox1;
        private Label label3;
        private TextBox lname_textBox1;
        private Label label2;
        private Label label1;
        private TextBox fname_textBox2;
        private Button back_button2;
    }
}