namespace WinFormsApp1
{
    partial class Cafe_manager_inventory
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
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            back_button2 = new Button();
            textBox1 = new TextBox();
            ok_button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            Add_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 683);
            panel1.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(99, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 50);
            textBox3.TabIndex = 55;
            textBox3.Text = "INVENTORY";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(99, 86);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(804, 144);
            dataGridView2.TabIndex = 60;
            // 
            // back_button2
            // 
            back_button2.BackColor = Color.Black;
            back_button2.FlatAppearance.BorderSize = 0;
            back_button2.FlatStyle = FlatStyle.Flat;
            back_button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            back_button2.ForeColor = Color.White;
            back_button2.Location = new Point(99, 623);
            back_button2.Name = "back_button2";
            back_button2.Size = new Size(137, 35);
            back_button2.TabIndex = 67;
            back_button2.Text = " << Go Back";
            back_button2.UseVisualStyleBackColor = false;
            back_button2.Click += back_button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 512);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 70;
            // 
            // ok_button1
            // 
            ok_button1.BackColor = Color.Black;
            ok_button1.FlatAppearance.BorderSize = 0;
            ok_button1.FlatStyle = FlatStyle.Flat;
            ok_button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ok_button1.ForeColor = Color.White;
            ok_button1.Location = new Point(487, 512);
            ok_button1.Name = "ok_button1";
            ok_button1.Size = new Size(94, 29);
            ok_button1.TabIndex = 69;
            ok_button1.Text = "ok";
            ok_button1.UseVisualStyleBackColor = false;
            ok_button1.Click += ok_button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 509);
            label1.Name = "label1";
            label1.Size = new Size(198, 27);
            label1.TabIndex = 68;
            label1.Text = "Reorder amount:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(684, 144);
            dataGridView1.TabIndex = 71;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(99, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 50);
            textBox2.TabIndex = 72;
            textBox2.Text = "VENDOR";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.FromArgb(0, 0, 64);
            Add_button.FlatAppearance.BorderSize = 0;
            Add_button.FlatStyle = FlatStyle.Flat;
            Add_button.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Add_button.ForeColor = Color.White;
            Add_button.Location = new Point(762, 246);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(141, 35);
            Add_button.TabIndex = 82;
            Add_button.Text = "Add Vendor";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // Cafe_manager_inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 683);
            Controls.Add(Add_button);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(ok_button1);
            Controls.Add(label1);
            Controls.Add(back_button2);
            Controls.Add(dataGridView2);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Name = "Cafe_manager_inventory";
            Text = "Cafe_manager_inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private DataGridView dataGridView2;
        private Button back_button2;
        private TextBox textBox1;
        private Button ok_button1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Button Add_button;
    }
}