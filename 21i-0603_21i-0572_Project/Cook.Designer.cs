namespace WinFormsApp1
{
    partial class Cook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cook));
            label2 = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox1 = new PictureBox();
            logout_button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(114, 102);
            label2.Name = "label2";
            label2.Size = new Size(106, 34);
            label2.TabIndex = 45;
            label2.Text = "Name:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(242, 114);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(237, 27);
            textBox4.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(102, 157);
            label1.Name = "label1";
            label1.Size = new Size(118, 34);
            label1.TabIndex = 47;
            label1.Text = "Staff ID:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(242, 162);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 48;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(77, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 50);
            textBox3.TabIndex = 49;
            textBox3.Text = "COOK";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 447);
            panel1.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(550, 34);
            label3.Name = "label3";
            label3.Size = new Size(224, 37);
            label3.TabIndex = 51;
            label3.Text = "Today's Menu:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(550, 89);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(302, 298);
            dataGridView2.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // logout_button1
            // 
            logout_button1.BackColor = Color.Black;
            logout_button1.FlatAppearance.BorderSize = 0;
            logout_button1.FlatStyle = FlatStyle.Flat;
            logout_button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button1.ForeColor = Color.White;
            logout_button1.Location = new Point(749, 400);
            logout_button1.Name = "logout_button1";
            logout_button1.Size = new Size(103, 35);
            logout_button1.TabIndex = 64;
            logout_button1.Text = "Log out";
            logout_button1.UseVisualStyleBackColor = false;
            logout_button1.Click += logout_button1_Click;
            // 
            // Cook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(895, 447);
            Controls.Add(logout_button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Name = "Cook";
            Text = "Cook";
            Load += Cook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Panel panel1;
        private Label label3;
        private DataGridView dataGridView2;
        private PictureBox pictureBox1;
        private Button logout_button1;
    }
}