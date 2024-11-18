namespace WinFormsApp1
{
    partial class Admin
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
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Admin";
        //}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel2 = new Panel();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ok_button1 = new Button();
            label1 = new Label();
            back_button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(71, 442);
            panel2.TabIndex = 51;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(77, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 50);
            textBox3.TabIndex = 52;
            textBox3.Text = "MANAGE INVENTORY";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(881, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(98, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(684, 164);
            dataGridView1.TabIndex = 77;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 76;
            // 
            // ok_button1
            // 
            ok_button1.BackColor = Color.Black;
            ok_button1.FlatAppearance.BorderSize = 0;
            ok_button1.FlatStyle = FlatStyle.Flat;
            ok_button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ok_button1.ForeColor = Color.White;
            ok_button1.Location = new Point(488, 284);
            ok_button1.Name = "ok_button1";
            ok_button1.Size = new Size(94, 29);
            ok_button1.TabIndex = 75;
            ok_button1.Text = "ok";
            ok_button1.UseVisualStyleBackColor = false;
            ok_button1.Click += ok_button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 281);
            label1.Name = "label1";
            label1.Size = new Size(198, 27);
            label1.TabIndex = 74;
            label1.Text = "Reorder amount:";
            // 
            // back_button2
            // 
            back_button2.BackColor = Color.Black;
            back_button2.FlatAppearance.BorderSize = 0;
            back_button2.FlatStyle = FlatStyle.Flat;
            back_button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            back_button2.ForeColor = Color.White;
            back_button2.Location = new Point(98, 382);
            back_button2.Name = "back_button2";
            back_button2.Size = new Size(137, 35);
            back_button2.TabIndex = 73;
            back_button2.Text = " << Go Back";
            back_button2.UseVisualStyleBackColor = false;
            back_button2.Click += back_button2_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 442);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(ok_button1);
            Controls.Add(label1);
            Controls.Add(back_button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(panel2);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button ok_button1;
        private Label label1;
        private Button back_button2;
    }
}