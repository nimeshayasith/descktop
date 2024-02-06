using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StudentRegistrationSystem
{
	public partial class AddStudent : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nimes\OneDrive\Documents\students.mdf;Integrated Security=True;Connect Timeout=30");

        public AddStudent()
        {
            InitializeComponent();

            // TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayStudentData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayStudentData();
        }

        public void displayStudentData()
        {
            StudentData ed = new StudentData();
            List<StudentData> listData = ed.studentListData();

            dataGridView1.DataSource = listData;
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if(addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStudent_batch.Text == ""
                || addStudent_status.Text == ""
                || addStudent_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM students WHERE student_id = @emID AND delete_date IS NULL";

                        using(SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addStudent_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addStudent_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students " +
                                    "(student_id, full_name, gender, contact_number" +
                                    ", batch, image, insert_date, status) " +
                                    "VALUES(@studentID, @fullName, @gender, @contactNum" +
                                    ", @batch, @image, @insertDate, @status)";

                                string path = Path.Combine(@"E:\New folder\Employee-Management-System-in-CSharp-main\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
									+ addStudent_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addStudent_picture.ImageLocation, path, true);

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", addStudent_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addStudent_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addStudent_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addStudent_phoneNum.Text.Trim());
                                    cmd.Parameters.AddWithValue("@batch", addStudent_batch.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addStudent_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayStudentData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addStudent_picture.ImageLocation = imagePath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addStudent_id.Text = row.Cells[1].Value.ToString();
                addStudent_fullName.Text = row.Cells[2].Value.ToString();
                addStudent_gender.Text = row.Cells[3].Value.ToString();
                addStudent_phoneNum.Text = row.Cells[4].Value.ToString();
                addStudent_batch.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {
                    addStudent_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addStudent_picture.Image = null;
                }

                addStudent_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            addStudent_id.Text = "";
            addStudent_fullName.Text = "";
            addStudent_gender.SelectedIndex = -1;
            addStudent_phoneNum.Text = "";
            addStudent_batch.SelectedIndex = -1;
            addStudent_status.SelectedIndex = -1;
            addStudent_picture.Image = null;
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStudent_batch.Text == ""
                || addStudent_status.Text == ""
                || addStudent_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addStudent_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE students SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", batch = @batch, update_date = @updateDate, status = @status " +
                            "WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addStudent_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addStudent_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addStudent_phoneNum.Text.Trim());
                            cmd.Parameters.AddWithValue("@batch", addStudent_batch.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addStudent_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentID", addStudent_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStudent_batch.Text == ""
                || addStudent_status.Text == ""
                || addStudent_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Student ID: " + addStudent_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE students SET delete_date = @deleteDate " +
                            "WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@studentID", addStudent_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
