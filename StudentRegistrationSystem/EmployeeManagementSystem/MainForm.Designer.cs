namespace StudentRegistrationSystem
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.greet_user = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.logout_btn = new System.Windows.Forms.Button();
			this.addStudent_btn = new System.Windows.Forms.Button();
			this.dashboard_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.addStudent1 = new StudentRegistrationSystem.AddStudent();
			this.dashboard1 = new StudentRegistrationSystem.Dashboard();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.exit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1467, 43);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(9, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Student Registration System";
			// 
			// exit
			// 
			this.exit.AutoSize = true;
			this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exit.ForeColor = System.Drawing.Color.White;
			this.exit.Location = new System.Drawing.Point(1439, 10);
			this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(20, 21);
			this.exit.TabIndex = 0;
			this.exit.Text = "X";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.logout_btn);
			this.panel2.Controls.Add(this.addStudent_btn);
			this.panel2.Controls.Add(this.dashboard_btn);
			this.panel2.Controls.Add(this.greet_user);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 43);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 695);
			this.panel2.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(71, 649);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sign Out";
			// 
			// greet_user
			// 
			this.greet_user.AutoSize = true;
			this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.greet_user.ForeColor = System.Drawing.Color.White;
			this.greet_user.Location = new System.Drawing.Point(103, 182);
			this.greet_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.greet_user.Name = "greet_user";
			this.greet_user.Size = new System.Drawing.Size(92, 24);
			this.greet_user.TabIndex = 1;
			this.greet_user.Text = "Welcome";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dashboard1);
			this.panel3.Controls.Add(this.addStudent1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(300, 43);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1167, 695);
			this.panel3.TabIndex = 2;
			// 
			// logout_btn
			// 
			this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logout_btn.FlatAppearance.BorderSize = 0;
			this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_btn.ForeColor = System.Drawing.Color.White;
			this.logout_btn.Image = global::StudentRegistrationSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
			this.logout_btn.Location = new System.Drawing.Point(15, 636);
			this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
			this.logout_btn.Name = "logout_btn";
			this.logout_btn.Size = new System.Drawing.Size(47, 43);
			this.logout_btn.TabIndex = 5;
			this.logout_btn.UseVisualStyleBackColor = true;
			this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
			// 
			// addStudent_btn
			// 
			this.addStudent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.addStudent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addStudent_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.addStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addStudent_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStudent_btn.ForeColor = System.Drawing.Color.White;
			this.addStudent_btn.Image = global::StudentRegistrationSystem.Properties.Resources.icons8_employee_card_30px;
			this.addStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addStudent_btn.Location = new System.Drawing.Point(19, 341);
			this.addStudent_btn.Margin = new System.Windows.Forms.Padding(4);
			this.addStudent_btn.Name = "addStudent_btn";
			this.addStudent_btn.Size = new System.Drawing.Size(267, 49);
			this.addStudent_btn.TabIndex = 3;
			this.addStudent_btn.Text = "ADD STUDENT";
			this.addStudent_btn.UseVisualStyleBackColor = false;
			this.addStudent_btn.Click += new System.EventHandler(this.addStudent_btn_Click);
			// 
			// dashboard_btn
			// 
			this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
			this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
			this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboard_btn.ForeColor = System.Drawing.Color.White;
			this.dashboard_btn.Image = global::StudentRegistrationSystem.Properties.Resources.icons8_dashboard_30px;
			this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dashboard_btn.Location = new System.Drawing.Point(19, 271);
			this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
			this.dashboard_btn.Name = "dashboard_btn";
			this.dashboard_btn.Size = new System.Drawing.Size(267, 49);
			this.dashboard_btn.TabIndex = 2;
			this.dashboard_btn.Text = "DASHBOARD";
			this.dashboard_btn.UseVisualStyleBackColor = false;
			this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StudentRegistrationSystem.Properties.Resources.male;
			this.pictureBox1.Location = new System.Drawing.Point(83, 55);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 123);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// addStudent2
			// 
			this.addStudent1.Location = new System.Drawing.Point(0, 0);
			this.addStudent1.Margin = new System.Windows.Forms.Padding(4);
			this.addStudent1.Name = "addStudent2";
			this.addStudent1.Size = new System.Drawing.Size(1167, 695);
			this.addStudent1.TabIndex = 0;
			// 
			// dashboard2
			// 
			this.dashboard1.Location = new System.Drawing.Point(0, 0);
			this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
			this.dashboard1.Name = "dashboard2";
			this.dashboard1.Size = new System.Drawing.Size(1167, 695);
			this.dashboard1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1467, 738);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label exit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label greet_user;
		private System.Windows.Forms.Button dashboard_btn;
		private System.Windows.Forms.Button addStudent_btn;
		private System.Windows.Forms.Button logout_btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private Dashboard dashboard1;
		private AddStudent addStudent1;
	}
}