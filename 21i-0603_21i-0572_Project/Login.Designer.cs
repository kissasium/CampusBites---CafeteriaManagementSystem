namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            email = new Label();
            password = new Label();
            emailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(376, 55);
            label1.Name = "label1";
            label1.Size = new Size(323, 70);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Black;
            email.Location = new Point(244, 266);
            email.Name = "email";
            email.Size = new Size(88, 34);
            email.TabIndex = 2;
            email.Text = "Email";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(244, 338);
            password.Name = "password";
            password.Size = new Size(142, 34);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(434, 274);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(217, 30);
            emailtextBox.TabIndex = 5;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(434, 338);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(217, 30);
            PasswordtextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(500, 408);
            button1.Name = "button1";
            button1.Size = new Size(88, 37);
            button1.TabIndex = 7;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.WhiteSmoke;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(425, 485);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(245, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "New User? Sign up here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(PasswordtextBox);
            panel3.Controls.Add(emailtextBox);
            panel3.Controls.Add(password);
            panel3.Controls.Add(email);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 588);
            panel3.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 588);
            Controls.Add(panel3);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label email;
        private Label password;
        private TextBox emailtextBox;
        private TextBox PasswordtextBox;
        private Button button1;
        private LinkLabel linkLabel1;
        private Panel panel3;
    }
}