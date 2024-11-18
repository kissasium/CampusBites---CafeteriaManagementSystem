namespace WinFormsApp1
{
    partial class report
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
            back_button2 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            dataGridView5 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 1015);
            panel1.TabIndex = 54;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(77, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 50);
            textBox3.TabIndex = 55;
            textBox3.Text = "REPORT";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // back_button2
            // 
            back_button2.BackColor = Color.Black;
            back_button2.FlatAppearance.BorderSize = 0;
            back_button2.FlatStyle = FlatStyle.Flat;
            back_button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            back_button2.ForeColor = Color.White;
            back_button2.Location = new Point(105, 959);
            back_button2.Name = "back_button2";
            back_button2.Size = new Size(137, 35);
            back_button2.TabIndex = 74;
            back_button2.Text = " << Go Back";
            back_button2.UseVisualStyleBackColor = false;
            back_button2.Click += back_button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(98, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(553, 90);
            dataGridView1.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 83);
            label2.Name = "label2";
            label2.Size = new Size(225, 34);
            label2.TabIndex = 76;
            label2.Text = "Most sold item: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(98, 431);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 77;
            label1.Text = "Least sold item: ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(98, 486);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(553, 90);
            dataGridView2.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(98, 258);
            label3.Name = "label3";
            label3.Size = new Size(540, 34);
            label3.TabIndex = 79;
            label3.Text = "Customer who bought most sold item: ";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.WhiteSmoke;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView3.GridColor = Color.DarkGray;
            dataGridView3.Location = new Point(105, 307);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(806, 90);
            dataGridView3.TabIndex = 80;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.WhiteSmoke;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView4.GridColor = Color.DarkGray;
            dataGridView4.Location = new Point(105, 644);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(806, 90);
            dataGridView4.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(98, 595);
            label4.Name = "label4";
            label4.Size = new Size(539, 34);
            label4.TabIndex = 81;
            label4.Text = "Customer who bought least sold item: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(98, 767);
            label5.Name = "label5";
            label5.Size = new Size(568, 34);
            label5.TabIndex = 83;
            label5.Text = "Customer who generated most revenue:";
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = Color.WhiteSmoke;
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView5.GridColor = Color.DarkGray;
            dataGridView5.Location = new Point(105, 821);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 29;
            dataGridView5.Size = new Size(806, 90);
            dataGridView5.TabIndex = 84;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(769, 959);
            button1.Name = "button1";
            button1.Size = new Size(142, 35);
            button1.TabIndex = 85;
            button1.Text = "Next Page >>";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 1015);
            Controls.Add(button1);
            Controls.Add(dataGridView5);
            Controls.Add(label5);
            Controls.Add(dataGridView4);
            Controls.Add(label4);
            Controls.Add(dataGridView3);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(back_button2);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            ForeColor = Color.WhiteSmoke;
            Name = "report";
            Text = "report";
            Load += report_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Button back_button2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView5;
        private Button button1;
    }
}