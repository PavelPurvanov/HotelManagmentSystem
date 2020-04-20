namespace HotelManagementSystem
{
    partial class rooms_form
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
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_room_number = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_button.Location = new System.Drawing.Point(60, 387);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(167, 60);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.update_button.Location = new System.Drawing.Point(60, 309);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(167, 60);
            this.update_button.TabIndex = 13;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(298, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 426);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_room_number);
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(4, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_price.Location = new System.Drawing.Point(132, 157);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(124, 20);
            this.txt_price.TabIndex = 10;

            // 
            // txt_room_number
            // 
            this.txt_room_number.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_room_number.Location = new System.Drawing.Point(132, 89);
            this.txt_room_number.Name = "txt_room_number";
            this.txt_room_number.Size = new System.Drawing.Size(124, 20);
            this.txt_room_number.TabIndex = 9;
            this.txt_room_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_room_number_KeyPress);
            // 
            // txt_type
            // 
            this.txt_type.BackColor = System.Drawing.Color.Gray;
            this.txt_type.Location = new System.Drawing.Point(132, 30);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(124, 20);
            this.txt_type.TabIndex = 8;
            this.txt_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_type_KeyPress);
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.insert_button.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insert_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insert_button.Location = new System.Drawing.Point(60, 230);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(167, 60);
            this.insert_button.TabIndex = 10;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // rooms_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(922, 469);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insert_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "rooms_form";
            this.Text = "rooms_table";
            this.Load += new System.EventHandler(this.rooms_table_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_room_number;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button insert_button;
    }
}