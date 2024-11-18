namespace WinFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            panelLeft = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 543);
            panel1.TabIndex = 10;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 0, 0);
            panelLeft.Location = new Point(3, 166);
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
            button4.Location = new Point(0, 356);
            button4.Name = "button4";
            button4.Size = new Size(194, 89);
            button4.TabIndex = 13;
            button4.Text = "Profile";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 261);
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
            button2.Location = new Point(0, 166);
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
            button1.Location = new Point(0, 71);
            button1.Name = "button1";
            button1.Size = new Size(194, 89);
            button1.TabIndex = 10;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(215, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 50);
            textBox3.TabIndex = 15;
            textBox3.Text = "MENU";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(296, 123);
            button5.Name = "button5";
            button5.Size = new Size(194, 141);
            button5.TabIndex = 16;
            button5.Text = "Beverages";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(571, 123);
            button6.Name = "button6";
            button6.Size = new Size(194, 141);
            button6.TabIndex = 17;
            button6.Text = "Meals";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(838, 123);
            button7.Name = "button7";
            button7.Size = new Size(194, 141);
            button7.TabIndex = 18;
            button7.Text = "Breakfast";
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(296, 313);
            button8.Name = "button8";
            button8.Size = new Size(194, 141);
            button8.TabIndex = 19;
            button8.Text = "Snacks";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(571, 313);
            button9.Name = "button9";
            button9.Size = new Size(194, 141);
            button9.TabIndex = 20;
            button9.Text = "Dessert";
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(838, 313);
            button10.Name = "button10";
            button10.Size = new Size(194, 141);
            button10.TabIndex = 21;
            button10.Text = "Café";
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1038, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1165, 543);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Panel panelLeft;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private PictureBox pictureBox1;
    }
}