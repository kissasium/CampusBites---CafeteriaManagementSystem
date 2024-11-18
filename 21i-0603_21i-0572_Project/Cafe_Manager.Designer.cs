namespace WinFormsApp1
{
    partial class Cafe_Manager
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
            logout_button1 = new Button();
            employee_button1 = new Button();
            menu_button1 = new Button();
            inventory_button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 509);
            panel1.TabIndex = 53;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(77, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(337, 50);
            textBox3.TabIndex = 54;
            textBox3.Text = "CAFE MANAGER";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // logout_button1
            // 
            logout_button1.BackColor = Color.Black;
            logout_button1.FlatAppearance.BorderSize = 0;
            logout_button1.FlatStyle = FlatStyle.Flat;
            logout_button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button1.ForeColor = Color.White;
            logout_button1.Location = new Point(468, 453);
            logout_button1.Name = "logout_button1";
            logout_button1.Size = new Size(103, 35);
            logout_button1.TabIndex = 63;
            logout_button1.Text = "Log out";
            logout_button1.UseVisualStyleBackColor = false;
            logout_button1.Click += logout_button1_Click;
            // 
            // employee_button1
            // 
            employee_button1.BackColor = Color.FromArgb(0, 0, 64);
            employee_button1.FlatAppearance.BorderSize = 0;
            employee_button1.FlatStyle = FlatStyle.Flat;
            employee_button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            employee_button1.ForeColor = Color.White;
            employee_button1.Location = new Point(107, 111);
            employee_button1.Name = "employee_button1";
            employee_button1.Size = new Size(183, 140);
            employee_button1.TabIndex = 64;
            employee_button1.Text = "Employee Information";
            employee_button1.TextImageRelation = TextImageRelation.ImageAboveText;
            employee_button1.UseVisualStyleBackColor = false;
            employee_button1.Click += employee_button1_Click;
            // 
            // menu_button1
            // 
            menu_button1.BackColor = Color.FromArgb(0, 0, 64);
            menu_button1.FlatAppearance.BorderSize = 0;
            menu_button1.FlatStyle = FlatStyle.Flat;
            menu_button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menu_button1.ForeColor = Color.White;
            menu_button1.Location = new Point(388, 111);
            menu_button1.Name = "menu_button1";
            menu_button1.Size = new Size(183, 140);
            menu_button1.TabIndex = 65;
            menu_button1.Text = "Menu";
            menu_button1.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_button1.UseVisualStyleBackColor = false;
            menu_button1.Click += menu_button1_Click;
            // 
            // inventory_button2
            // 
            inventory_button2.BackColor = Color.FromArgb(0, 0, 64);
            inventory_button2.FlatAppearance.BorderSize = 0;
            inventory_button2.FlatStyle = FlatStyle.Flat;
            inventory_button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_button2.ForeColor = Color.White;
            inventory_button2.Location = new Point(107, 280);
            inventory_button2.Name = "inventory_button2";
            inventory_button2.Size = new Size(183, 140);
            inventory_button2.TabIndex = 66;
            inventory_button2.Text = "Inventory";
            inventory_button2.TextImageRelation = TextImageRelation.ImageAboveText;
            inventory_button2.UseVisualStyleBackColor = false;
            inventory_button2.Click += inventory_button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(388, 280);
            button1.Name = "button1";
            button1.Size = new Size(183, 140);
            button1.TabIndex = 67;
            button1.Text = "Generate Report";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cafe_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 509);
            Controls.Add(button1);
            Controls.Add(inventory_button2);
            Controls.Add(menu_button1);
            Controls.Add(employee_button1);
            Controls.Add(logout_button1);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Name = "Cafe_Manager";
            Text = "Cafe_Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Button logout_button1;
        private Button employee_button1;
        private Button menu_button1;
        private Button inventory_button2;
        private Button button1;
    }
}