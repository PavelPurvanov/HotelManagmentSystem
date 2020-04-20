namespace HotelManagementSystem
{
    partial class clients_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_egn = new System.Windows.Forms.TextBox();
            this.txt_last_name = new System.Windows.Forms.TextBox();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.insert_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insert_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_button.Location = new System.Drawing.Point(47, 384);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(167, 60);
            this.insert_button.TabIndex = 5;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_egn);
            this.groupBox1.Controls.Add(this.txt_last_name);
            this.groupBox1.Controls.Add(this.txt_first_name);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 357);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(4, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(4, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(4, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "EGN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_address.ForeColor = System.Drawing.Color.White;
            this.txt_address.Location = new System.Drawing.Point(113, 307);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(124, 20);
            this.txt_address.TabIndex = 12;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_phone.ForeColor = System.Drawing.Color.White;
            this.txt_phone.Location = new System.Drawing.Point(113, 233);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(124, 20);
            this.txt_phone.TabIndex = 11;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_egn
            // 
            this.txt_egn.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_egn.ForeColor = System.Drawing.Color.White;
            this.txt_egn.Location = new System.Drawing.Point(113, 157);
            this.txt_egn.Name = "txt_egn";
            this.txt_egn.Size = new System.Drawing.Size(124, 20);
            this.txt_egn.TabIndex = 10;
            this.txt_egn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_egn_KeyPress);
            // 
            // txt_last_name
            // 
            this.txt_last_name.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_last_name.ForeColor = System.Drawing.Color.White;
            this.txt_last_name.Location = new System.Drawing.Point(113, 88);
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(124, 20);
            this.txt_last_name.TabIndex = 9;
            this.txt_last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_last_name_KeyPress);
            // 
            // txt_first_name
            // 
            this.txt_first_name.BackColor = System.Drawing.Color.Gray;
            this.txt_first_name.ForeColor = System.Drawing.Color.White;
            this.txt_first_name.Location = new System.Drawing.Point(113, 28);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(124, 20);
            this.txt_first_name.TabIndex = 8;
            this.txt_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_first_name_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(254, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 348);
            this.panel1.TabIndex = 7;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.update_button.Location = new System.Drawing.Point(371, 384);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(167, 60);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_button.Location = new System.Drawing.Point(673, 384);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(167, 60);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clients_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(916, 460);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insert_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "clients_form";
            this.Text = "clients_from";
            this.Load += new System.EventHandler(this.clients_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_egn;
        private System.Windows.Forms.TextBox txt_last_name;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
    }
}