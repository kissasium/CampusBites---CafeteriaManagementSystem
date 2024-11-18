namespace WinFormsApp1
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            panel1 = new Panel();
            panelLeft = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            update_button = new Button();
            passwordtextBox = new TextBox();
            password = new Label();
            phonenumtextBox = new TextBox();
            phonenum = new Label();
            emailtextBox = new TextBox();
            email = new Label();
            lnametextBox = new TextBox();
            lname = new Label();
            fnametextBox = new TextBox();
            fname = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 543);
            panel1.TabIndex = 11;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 0, 0);
            panelLeft.Location = new Point(0, 94);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(7, 89);
            panelLeft.TabIndex = 11;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 284);
            button3.Name = "button3";
            button3.Size = new Size(194, 89);
            button3.TabIndex = 12;
            button3.Text = "Support";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 189);
            button2.Name = "button2";
            button2.Size = new Size(194, 89);
            button2.TabIndex = 11;
            button2.Text = "Menu";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 94);
            button1.Name = "button1";
            button1.Size = new Size(194, 89);
            button1.TabIndex = 10;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // update_button
            // 
            update_button.BackColor = Color.Black;
            update_button.FlatAppearance.BorderSize = 0;
            update_button.FlatStyle = FlatStyle.Flat;
            update_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            update_button.ForeColor = Color.White;
            update_button.Location = new Point(497, 450);
            update_button.Name = "update_button";
            update_button.Size = new Size(97, 35);
            update_button.TabIndex = 38;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(440, 380);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(217, 27);
            passwordtextBox.TabIndex = 37;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Black;
            password.Location = new Point(239, 380);
            password.Name = "password";
            password.Size = new Size(103, 23);
            password.TabIndex = 36;
            password.Text = "Password";
            // 
            // phonenumtextBox
            // 
            phonenumtextBox.Location = new Point(440, 316);
            phonenumtextBox.Name = "phonenumtextBox";
            phonenumtextBox.Size = new Size(217, 27);
            phonenumtextBox.TabIndex = 35;
            // 
            // phonenum
            // 
            phonenum.AutoSize = true;
            phonenum.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phonenum.ForeColor = Color.Black;
            phonenum.Location = new Point(239, 316);
            phonenum.Name = "phonenum";
            phonenum.Size = new Size(154, 23);
            phonenum.TabIndex = 34;
            phonenum.Text = "Phone number";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(440, 253);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(217, 27);
            emailtextBox.TabIndex = 33;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Black;
            email.Location = new Point(239, 253);
            email.Name = "email";
            email.Size = new Size(62, 23);
            email.TabIndex = 32;
            email.Text = "Email";
            // 
            // lnametextBox
            // 
            lnametextBox.Location = new Point(440, 191);
            lnametextBox.Name = "lnametextBox";
            lnametextBox.Size = new Size(217, 27);
            lnametextBox.TabIndex = 31;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname.ForeColor = Color.Black;
            lname.Location = new Point(239, 191);
            lname.Name = "lname";
            lname.Size = new Size(115, 23);
            lname.TabIndex = 30;
            lname.Text = "Last Name";
            // 
            // fnametextBox
            // 
            fnametextBox.Location = new Point(440, 132);
            fnametextBox.Name = "fnametextBox";
            fnametextBox.Size = new Size(217, 27);
            fnametextBox.TabIndex = 29;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname.ForeColor = Color.Black;
            fname.Location = new Point(239, 132);
            fname.Name = "fname";
            fname.Size = new Size(111, 23);
            fname.TabIndex = 28;
            fname.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(221, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 44);
            label1.TabIndex = 27;
            label1.Text = "PROFILE";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(820, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 543);
            Controls.Add(pictureBox1);
            Controls.Add(update_button);
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
            Controls.Add(panel1);
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button update_button;
        private TextBox passwordtextBox;
        private Label password;
        private TextBox phonenumtextBox;
        private Label phonenum;
        private TextBox emailtextBox;
        private Label email;
        private TextBox lnametextBox;
        private Label lname;
        private TextBox fnametextBox;
        private Label fname;
        private Label label1;
        private PictureBox pictureBox1;
    }
}