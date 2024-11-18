namespace WinFormsApp1
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            TASKS = new Label();
            fnametextBox = new TextBox();
            fname = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lnametextBox = new TextBox();
            lname = new Label();
            emailtextBox = new TextBox();
            email = new Label();
            phonenumtextBox = new TextBox();
            phonenum = new Label();
            passwordtextBox = new TextBox();
            password = new Label();
            signupbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TASKS
            // 
            TASKS.AutoSize = true;
            TASKS.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TASKS.Location = new Point(22, 9);
            TASKS.Name = "TASKS";
            TASKS.Size = new Size(0, 41);
            TASKS.TabIndex = 2;
            // 
            // fnametextBox
            // 
            fnametextBox.Location = new Point(554, 164);
            fnametextBox.Name = "fnametextBox";
            fnametextBox.Size = new Size(217, 27);
            fnametextBox.TabIndex = 14;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname.ForeColor = Color.Black;
            fname.Location = new Point(353, 164);
            fname.Name = "fname";
            fname.Size = new Size(111, 23);
            fname.TabIndex = 12;
            fname.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(348, 82);
            label1.Name = "label1";
            label1.Size = new Size(170, 44);
            label1.TabIndex = 11;
            label1.Text = "Register:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lnametextBox
            // 
            lnametextBox.Location = new Point(554, 223);
            lnametextBox.Name = "lnametextBox";
            lnametextBox.Size = new Size(217, 27);
            lnametextBox.TabIndex = 19;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname.ForeColor = Color.Black;
            lname.Location = new Point(353, 223);
            lname.Name = "lname";
            lname.Size = new Size(115, 23);
            lname.TabIndex = 18;
            lname.Text = "Last Name";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(554, 285);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(217, 27);
            emailtextBox.TabIndex = 21;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Black;
            email.Location = new Point(353, 285);
            email.Name = "email";
            email.Size = new Size(62, 23);
            email.TabIndex = 20;
            email.Text = "Email";
            // 
            // phonenumtextBox
            // 
            phonenumtextBox.Location = new Point(554, 348);
            phonenumtextBox.Name = "phonenumtextBox";
            phonenumtextBox.Size = new Size(217, 27);
            phonenumtextBox.TabIndex = 23;
            // 
            // phonenum
            // 
            phonenum.AutoSize = true;
            phonenum.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phonenum.ForeColor = Color.Black;
            phonenum.Location = new Point(353, 348);
            phonenum.Name = "phonenum";
            phonenum.Size = new Size(154, 23);
            phonenum.TabIndex = 22;
            phonenum.Text = "Phone number";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(554, 412);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(217, 27);
            passwordtextBox.TabIndex = 25;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(353, 412);
            password.Name = "password";
            password.Size = new Size(103, 23);
            password.TabIndex = 24;
            password.Text = "Password";
            // 
            // signupbutton
            // 
            signupbutton.BackColor = Color.Black;
            signupbutton.FlatAppearance.BorderSize = 0;
            signupbutton.FlatStyle = FlatStyle.Flat;
            signupbutton.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            signupbutton.ForeColor = Color.White;
            signupbutton.Location = new Point(606, 480);
            signupbutton.Name = "signupbutton";
            signupbutton.Size = new Size(99, 31);
            signupbutton.TabIndex = 26;
            signupbutton.Text = "SignUp";
            signupbutton.UseVisualStyleBackColor = false;
            signupbutton.Click += signupbutton_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1165, 543);
            Controls.Add(signupbutton);
            Controls.Add(passwordtextBox);
            Controls.Add(password);
            Controls.Add(phonenumtextBox);
            Controls.Add(phonenum);
            Controls.Add(emailtextBox);
            Controls.Add(email);
            Controls.Add(lnametextBox);
            Controls.Add(lname);
            Controls.Add(fnametextBox);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(TASKS);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TASKS;
        private Button signup;
        private TextBox fnametextBox;
        private Label fname;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox lnametextBox;
        private Label lname;
        private TextBox emailtextBox;
        private Label email;
        private TextBox phonenumtextBox;
        private Label phonenum;
        private TextBox passwordtextBox;
        private Label password;
        private Button signupbutton;
    }
}