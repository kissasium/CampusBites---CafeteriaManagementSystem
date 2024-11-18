namespace WinFormsApp1
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            panel1 = new Panel();
            panelLeft = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label3 = new Label();
            feedback_richTextBox1 = new RichTextBox();
            save_button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 450);
            panel1.TabIndex = 11;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 0, 0);
            panelLeft.Location = new Point(3, 97);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(7, 89);
            panelLeft.TabIndex = 11;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 287);
            button4.Name = "button4";
            button4.Size = new Size(194, 89);
            button4.TabIndex = 13;
            button4.Text = "Profile";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 192);
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
            button1.Location = new Point(0, 97);
            button1.Name = "button1";
            button1.Size = new Size(194, 89);
            button1.TabIndex = 10;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(738, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(203, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(385, 50);
            textBox3.TabIndex = 24;
            textBox3.Text = "CONTACT SUPPORT";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(217, 90);
            label3.Name = "label3";
            label3.Size = new Size(443, 34);
            label3.TabIndex = 53;
            label3.Text = "Please leave us your feedback!";
            // 
            // feedback_richTextBox1
            // 
            feedback_richTextBox1.Location = new Point(230, 158);
            feedback_richTextBox1.Name = "feedback_richTextBox1";
            feedback_richTextBox1.Size = new Size(574, 209);
            feedback_richTextBox1.TabIndex = 54;
            feedback_richTextBox1.Text = "";
            // 
            // save_button1
            // 
            save_button1.BackColor = Color.Black;
            save_button1.FlatAppearance.BorderSize = 0;
            save_button1.FlatStyle = FlatStyle.Flat;
            save_button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            save_button1.ForeColor = Color.White;
            save_button1.Location = new Point(701, 387);
            save_button1.Name = "save_button1";
            save_button1.Size = new Size(103, 35);
            save_button1.TabIndex = 64;
            save_button1.Text = "Save";
            save_button1.UseVisualStyleBackColor = false;
            save_button1.Click += save_button1_Click;
            // 
            // Support
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
            Controls.Add(save_button1);
            Controls.Add(feedback_richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Support";
            Text = "Support";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft;
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label3;
        private RichTextBox feedback_richTextBox1;
        private Button save_button1;
    }
}