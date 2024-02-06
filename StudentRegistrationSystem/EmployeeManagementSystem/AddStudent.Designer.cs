﻿
namespace StudentRegistrationSystem
{
    partial class AddStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.addStudent_status = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.addStudent_clearBtn = new System.Windows.Forms.Button();
			this.addStudent_deleteBtn = new System.Windows.Forms.Button();
			this.addStudent_updateBtn = new System.Windows.Forms.Button();
			this.addStudent_addBtn = new System.Windows.Forms.Button();
			this.addStudent_importBtn = new System.Windows.Forms.Button();
			this.addStudent_picture = new System.Windows.Forms.PictureBox();
			this.addStudent_batch = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.addStudent_phoneNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.addStudent_gender = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addStudent_fullName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addStudent_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.addStudent_picture)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(24, 30);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1118, 343);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(29, 73);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1064, 238);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Student\'s Data";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(0, 368);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1119, 278);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.addStudent_status);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.addStudent_clearBtn);
			this.panel3.Controls.Add(this.addStudent_deleteBtn);
			this.panel3.Controls.Add(this.addStudent_updateBtn);
			this.panel3.Controls.Add(this.addStudent_addBtn);
			this.panel3.Controls.Add(this.addStudent_importBtn);
			this.panel3.Controls.Add(this.addStudent_picture);
			this.panel3.Controls.Add(this.addStudent_batch);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.addStudent_phoneNum);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.addStudent_gender);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.addStudent_fullName);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.addStudent_id);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(24, 398);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1118, 264);
			this.panel3.TabIndex = 2;
			// 
			// addStudent_status
			// 
			this.addStudent_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_status.FormattingEnabled = true;
			this.addStudent_status.Items.AddRange(new object[] {
            "Active",
            "Ianctive"});
			this.addStudent_status.Location = new System.Drawing.Point(563, 133);
			this.addStudent_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_status.Name = "addStudent_status";
			this.addStudent_status.Size = new System.Drawing.Size(225, 26);
			this.addStudent_status.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(487, 133);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "Status:";
			// 
			// addStudent_clearBtn
			// 
			this.addStudent_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_clearBtn.FlatAppearance.BorderSize = 0;
			this.addStudent_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_clearBtn.ForeColor = System.Drawing.Color.White;
			this.addStudent_clearBtn.Location = new System.Drawing.Point(788, 201);
			this.addStudent_clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_clearBtn.Name = "addStudent_clearBtn";
			this.addStudent_clearBtn.Size = new System.Drawing.Size(151, 46);
			this.addStudent_clearBtn.TabIndex = 17;
			this.addStudent_clearBtn.Text = "Clear";
			this.addStudent_clearBtn.UseVisualStyleBackColor = false;
			this.addStudent_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
			// 
			// addStudent_deleteBtn
			// 
			this.addStudent_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_deleteBtn.FlatAppearance.BorderSize = 0;
			this.addStudent_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_deleteBtn.ForeColor = System.Drawing.Color.White;
			this.addStudent_deleteBtn.Location = new System.Drawing.Point(615, 201);
			this.addStudent_deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_deleteBtn.Name = "addStudent_deleteBtn";
			this.addStudent_deleteBtn.Size = new System.Drawing.Size(151, 46);
			this.addStudent_deleteBtn.TabIndex = 16;
			this.addStudent_deleteBtn.Text = "Delete";
			this.addStudent_deleteBtn.UseVisualStyleBackColor = false;
			this.addStudent_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
			// 
			// addStudent_updateBtn
			// 
			this.addStudent_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_updateBtn.FlatAppearance.BorderSize = 0;
			this.addStudent_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_updateBtn.ForeColor = System.Drawing.Color.White;
			this.addStudent_updateBtn.Location = new System.Drawing.Point(416, 201);
			this.addStudent_updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_updateBtn.Name = "addStudent_updateBtn";
			this.addStudent_updateBtn.Size = new System.Drawing.Size(151, 46);
			this.addStudent_updateBtn.TabIndex = 15;
			this.addStudent_updateBtn.Text = "Update";
			this.addStudent_updateBtn.UseVisualStyleBackColor = false;
			this.addStudent_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
			// 
			// addStudent_addBtn
			// 
			this.addStudent_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_addBtn.FlatAppearance.BorderSize = 0;
			this.addStudent_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_addBtn.ForeColor = System.Drawing.Color.White;
			this.addStudent_addBtn.Location = new System.Drawing.Point(243, 201);
			this.addStudent_addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_addBtn.Name = "addStudent_addBtn";
			this.addStudent_addBtn.Size = new System.Drawing.Size(151, 46);
			this.addStudent_addBtn.TabIndex = 14;
			this.addStudent_addBtn.Text = "Add";
			this.addStudent_addBtn.UseVisualStyleBackColor = false;
			this.addStudent_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
			// 
			// addStudent_importBtn
			// 
			this.addStudent_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_importBtn.FlatAppearance.BorderSize = 0;
			this.addStudent_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_importBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_importBtn.ForeColor = System.Drawing.Color.White;
			this.addStudent_importBtn.Location = new System.Drawing.Point(983, 155);
			this.addStudent_importBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_importBtn.Name = "addStudent_importBtn";
			this.addStudent_importBtn.Size = new System.Drawing.Size(109, 28);
			this.addStudent_importBtn.TabIndex = 13;
			this.addStudent_importBtn.Text = "Import";
			this.addStudent_importBtn.UseVisualStyleBackColor = false;
			this.addStudent_importBtn.Click += new System.EventHandler(this.addEmployee_importBtn_Click);
			// 
			// addStudent_picture
			// 
			this.addStudent_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.addStudent_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addStudent_picture.Location = new System.Drawing.Point(984, 42);
			this.addStudent_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_picture.Name = "addStudent_picture";
			this.addStudent_picture.Size = new System.Drawing.Size(109, 113);
			this.addStudent_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.addStudent_picture.TabIndex = 12;
			this.addStudent_picture.TabStop = false;
			// 
			// addStudent_batch
			// 
			this.addStudent_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_batch.FormattingEnabled = true;
			this.addStudent_batch.Items.AddRange(new object[] {
            "20th of Batch",
            "21th of Batch",
            "22th of Batch",
            "23th of Batch",
            "24th of Batch",
            "25th Of Batch"});
			this.addStudent_batch.Location = new System.Drawing.Point(563, 85);
			this.addStudent_batch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_batch.Name = "addStudent_batch";
			this.addStudent_batch.Size = new System.Drawing.Size(225, 26);
			this.addStudent_batch.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(485, 85);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Batch:";
			// 
			// addStudent_phoneNum
			// 
			this.addStudent_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_phoneNum.Location = new System.Drawing.Point(563, 42);
			this.addStudent_phoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_phoneNum.Name = "addStudent_phoneNum";
			this.addStudent_phoneNum.Size = new System.Drawing.Size(225, 24);
			this.addStudent_phoneNum.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(429, 42);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Phone Number:";
			// 
			// addStudent_gender
			// 
			this.addStudent_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_gender.FormattingEnabled = true;
			this.addStudent_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
			this.addStudent_gender.Location = new System.Drawing.Point(167, 137);
			this.addStudent_gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_gender.Name = "addStudent_gender";
			this.addStudent_gender.Size = new System.Drawing.Size(225, 26);
			this.addStudent_gender.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(89, 137);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Gender:";
			// 
			// addStudent_fullName
			// 
			this.addStudent_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_fullName.Location = new System.Drawing.Point(167, 92);
			this.addStudent_fullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_fullName.Name = "addStudent_fullName";
			this.addStudent_fullName.Size = new System.Drawing.Size(225, 24);
			this.addStudent_fullName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(68, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Full Name:";
			// 
			// addStudent_id
			// 
			this.addStudent_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_id.Location = new System.Drawing.Point(167, 43);
			this.addStudent_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addStudent_id.Name = "addStudent_id";
			this.addStudent_id.Size = new System.Drawing.Size(225, 24);
			this.addStudent_id.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student ID:";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel4.Location = new System.Drawing.Point(0, 368);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1119, 278);
			this.panel4.TabIndex = 1;
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddStudent";
			this.Size = new System.Drawing.Size(1167, 695);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.addStudent_picture)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addStudent_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addStudent_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addStudent_phoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addStudent_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addStudent_batch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addStudent_clearBtn;
        private System.Windows.Forms.Button addStudent_deleteBtn;
        private System.Windows.Forms.Button addStudent_updateBtn;
        private System.Windows.Forms.Button addStudent_addBtn;
        private System.Windows.Forms.Button addStudent_importBtn;
        private System.Windows.Forms.PictureBox addStudent_picture;
        private System.Windows.Forms.ComboBox addStudent_status;
        private System.Windows.Forms.Label label7;
    }
}
