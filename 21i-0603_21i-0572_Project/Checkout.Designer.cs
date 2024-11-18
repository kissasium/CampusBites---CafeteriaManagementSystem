namespace WinFormsApp1
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            textBox3 = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panelLeft = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button6 = new Button();
            button8 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(203, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 50);
            textBox3.TabIndex = 35;
            textBox3.Text = "CHECKOUT";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 575);
            panel1.TabIndex = 36;
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
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 0, 0);
            panelLeft.Location = new Point(0, 71);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(7, 89);
            panelLeft.TabIndex = 10;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(230, 126);
            label2.Name = "label2";
            label2.Size = new Size(211, 34);
            label2.TabIndex = 44;
            label2.Text = "Total Amount: ";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(452, 138);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(237, 20);
            textBox4.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 192);
            label1.Name = "label1";
            label1.Size = new Size(149, 34);
            label1.TabIndex = 46;
            label1.Text = "Discount: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(452, 204);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(237, 20);
            textBox1.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(230, 257);
            label3.Name = "label3";
            label3.Size = new Size(223, 34);
            label3.TabIndex = 48;
            label3.Text = "After Discount: ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(459, 269);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(237, 20);
            textBox2.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(230, 356);
            label4.Name = "label4";
            label4.Size = new Size(259, 34);
            label4.TabIndex = 50;
            label4.Text = "Payment Method:";
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(589, 433);
            button6.Name = "button6";
            button6.Size = new Size(133, 78);
            button6.TabIndex = 52;
            button6.Text = "Cash";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(241, 433);
            button8.Name = "button8";
            button8.Size = new Size(133, 78);
            button8.TabIndex = 54;
            button8.Text = "Credit Card";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(415, 433);
            button5.Name = "button5";
            button5.Size = new Size(133, 78);
            button5.TabIndex = 55;
            button5.Text = "Debit Card";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(816, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(283, 390);
            dataGridView1.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(816, 37);
            label5.Name = "label5";
            label5.Size = new Size(192, 34);
            label5.TabIndex = 57;
            label5.Text = "Order Details";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 0, 0);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(927, 510);
            button7.Name = "button7";
            button7.Size = new Size(172, 36);
            button7.TabIndex = 58;
            button7.Text = "Place Order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 575);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panelLeft;
        private Button button1;
        private Label label2;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button6;
        private Button button8;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label5;
        private Button button7;
    }
}