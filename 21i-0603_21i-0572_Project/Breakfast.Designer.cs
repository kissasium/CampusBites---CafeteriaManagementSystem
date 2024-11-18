namespace WinFormsApp1
{
    partial class Breakfast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Breakfast));
            panel1 = new Panel();
            panelLeft = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            pancakes_button8 = new Button();
            halwapuri_button11 = new Button();
            waffles_button10 = new Button();
            paratha_button5 = new Button();
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
            panel1.Size = new Size(197, 562);
            panel1.TabIndex = 13;
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
            textBox3.Location = new Point(214, 21);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 50);
            textBox3.TabIndex = 31;
            textBox3.Text = "BREAKFAST";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1010, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pancakes_button8
            // 
            pancakes_button8.BackColor = Color.WhiteSmoke;
            pancakes_button8.FlatAppearance.BorderSize = 0;
            pancakes_button8.FlatStyle = FlatStyle.Flat;
            pancakes_button8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pancakes_button8.Image = (Image)resources.GetObject("pancakes_button8.Image");
            pancakes_button8.ImageAlign = ContentAlignment.BottomCenter;
            pancakes_button8.Location = new Point(650, 326);
            pancakes_button8.Name = "pancakes_button8";
            pancakes_button8.Size = new Size(304, 204);
            pancakes_button8.TabIndex = 46;
            pancakes_button8.Text = "Pancakes PKR200";
            pancakes_button8.TextImageRelation = TextImageRelation.ImageAboveText;
            pancakes_button8.UseVisualStyleBackColor = false;
            pancakes_button8.Click += pancakes_button8_Click;
            // 
            // halwapuri_button11
            // 
            halwapuri_button11.BackColor = Color.WhiteSmoke;
            halwapuri_button11.FlatAppearance.BorderSize = 0;
            halwapuri_button11.FlatStyle = FlatStyle.Flat;
            halwapuri_button11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            halwapuri_button11.Image = (Image)resources.GetObject("halwapuri_button11.Image");
            halwapuri_button11.ImageAlign = ContentAlignment.BottomCenter;
            halwapuri_button11.Location = new Point(271, 326);
            halwapuri_button11.Name = "halwapuri_button11";
            halwapuri_button11.Size = new Size(304, 204);
            halwapuri_button11.TabIndex = 44;
            halwapuri_button11.Text = "Halwa Puri PKR180";
            halwapuri_button11.TextImageRelation = TextImageRelation.ImageAboveText;
            halwapuri_button11.UseVisualStyleBackColor = false;
            halwapuri_button11.Click += halwapuri_button11_Click;
            // 
            // waffles_button10
            // 
            waffles_button10.BackColor = Color.WhiteSmoke;
            waffles_button10.FlatAppearance.BorderSize = 0;
            waffles_button10.FlatStyle = FlatStyle.Flat;
            waffles_button10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            waffles_button10.Image = (Image)resources.GetObject("waffles_button10.Image");
            waffles_button10.ImageAlign = ContentAlignment.BottomCenter;
            waffles_button10.Location = new Point(271, 91);
            waffles_button10.Name = "waffles_button10";
            waffles_button10.Size = new Size(304, 204);
            waffles_button10.TabIndex = 43;
            waffles_button10.Text = "Waffles PKR200";
            waffles_button10.TextImageRelation = TextImageRelation.ImageAboveText;
            waffles_button10.UseVisualStyleBackColor = false;
            waffles_button10.Click += waffles_button10_Click;
            // 
            // paratha_button5
            // 
            paratha_button5.BackColor = Color.WhiteSmoke;
            paratha_button5.FlatAppearance.BorderSize = 0;
            paratha_button5.FlatStyle = FlatStyle.Flat;
            paratha_button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            paratha_button5.Image = (Image)resources.GetObject("paratha_button5.Image");
            paratha_button5.ImageAlign = ContentAlignment.BottomCenter;
            paratha_button5.Location = new Point(650, 91);
            paratha_button5.Name = "paratha_button5";
            paratha_button5.Size = new Size(304, 204);
            paratha_button5.TabIndex = 41;
            paratha_button5.Text = "Paratha PKR110";
            paratha_button5.TextImageRelation = TextImageRelation.ImageAboveText;
            paratha_button5.UseVisualStyleBackColor = false;
            paratha_button5.Click += paratha_button5_Click;
            // 
            // Breakfast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1139, 562);
            Controls.Add(pancakes_button8);
            Controls.Add(halwapuri_button11);
            Controls.Add(waffles_button10);
            Controls.Add(paratha_button5);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Name = "Breakfast";
            Text = "Breakfast ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Button pancakes_button8;
        private Button halwapuri_button11;
        private Button waffles_button10;
        private Button paratha_button5;
    }
}