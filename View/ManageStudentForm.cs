using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Dapper;
using Guna.UI2.WinForms;
using Student_Information_System.Controller;
using Student_Information_System.Model;
using System.Diagnostics;


namespace Student_Information_System.View
{
    public partial class ManageStudentForm : Form
    {
        #region Fields
        private static Int64 selectedStudentId;
        private Admin? admin = new();
        private Moderator? moderator = new();
        private List<Student> studentList = [];
        private User? studentUser;
        static Principal? principal;
        static readonly DBController dbController = new();
        readonly string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Images");
        readonly ColorSchemeController colorSchemeController = new();
        static ImageController? imageController;
        List<Control> schemeControls = [];

        #endregion
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        #region NOCONTROL CONTROLLER
        public static async Task<List<Student>> GetStudentsAsync(string query)
        {
            using var connection = dbController.GetConnection(); // Assuming you are using SQLite connection
            await connection.OpenAsync();

            // Using Dapper to query and map data to the Student class
            var students = await connection.QueryAsync<Student>(query);
            return students.ToList();
        }
        public async Task RefreshDataAsync()
        {
            gridStudents.Rows.Clear();
            var query = "SELECT student_id AS StudentId, profile_image AS ProfileImage, first_name AS FirstName, middle_name AS MiddleName, last_name AS LastName, age AS Age, sex AS Sex, user_id as UserId FROM students";
            // Fetch the list of students asynchronously using Dapper
            studentList = await GetStudentsAsync(query);
            //gridStudents.Rows.Clear();
            foreach (var student in studentList)
            {
                gridStudents.Rows.Add(student.ProfileImage, student.StudentId, student.FirstName, student.MiddleName, student.LastName, student.Age, student.Sex);
            }
            gridStudents.ClearSelection();
        }
        #endregion

        #region CONTROL CONTROLLER
        private async void ModForm_Load(object sender, EventArgs e)
        {
            principal = (Principal?)Thread.CurrentPrincipal;
            imageController = new(dbController, principal);
            schemeControls = [
                pnlTitle,pnlUser,pnlGridStud,btnCreate,ctrlClose,ctrlMin,picProfile,imgScheme,txtSearch,gridStudents
                ];
            if (colorSchemeController.ColorMode == ColorScheme.Light)
            {
                colorSchemeController.ApplyLightTheme(this, schemeControls);
            }
            else
            {
                colorSchemeController.ApplyDarkTheme(this, schemeControls);
            }
            switch (principal?.UserRole)
            {
                case UserRole.Admin:
                    admin = dbController.Execute(conn =>
                        conn.QuerySingleOrDefault<Admin>(
                            "SELECT admin_id AS AdminId, profile_image AS ProfileImage, user_id AS UserId FROM admins WHERE user_id = @UserId",
                            new { principal.UserId }
                        )
                    );
                    lblName.Visible = false;
                    lblRole.ForeColor = Color.Red;
                    if (admin?.ProfileImage == null)
                    {
                        imageController.SaveImageToDatabase(imageController.ImageToByteArray(Image.FromFile(Path.Combine(imagePath, "admin.png"))));
                        imageController.LoadProfileImage(picProfile);
                    }
                    else
                    {
                        imageController.LoadProfileImage(picProfile);
                    }
                    break;
                case UserRole.Moderator:
                    moderator = dbController.Execute(conn =>
                        conn.QuerySingleOrDefault<Moderator>(
                            "SELECT moderator_id AS ModeratorId, first_name AS FirstName, last_name AS LastName, profile_image AS ProfileImage, user_id AS UserId FROM moderators WHERE user_id = @UserId",
                            new { principal.UserId }
                        )
                    );
                    lblName.Text = $"{moderator?.FirstName} {moderator?.LastName}";
                    lblRole.ForeColor = Color.Yellow;
                    if (moderator?.ProfileImage == null)
                    {
                        imageController.SaveImageToDatabase(imageController.ImageToByteArray(Image.FromFile(Path.Combine(imagePath, "moderator.png"))));
                        imageController.LoadProfileImage(picProfile);
                    }
                    else
                    {
                        imageController.LoadProfileImage(picProfile);
                    }
                    break;
                default:
                    MessageBox.Show("Who Are you?");
                    Close();
                    break;
            }
            lblRole.Text = principal?.UserRole.ToString();
            await RefreshDataAsync();
        }

        //private async void OnCreateStudent(object sender, EventArgs e)
        //{
        //    // Step 1: Insert the new user and get the user_id
        //    string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@Username, @Password, @Role); SELECT last_insert_rowid();";
        //    var userId = dbController.Execute(conn => conn.ExecuteScalar<int>(insertUserQuery, new { Username = txtUsername.Text, Password = txtPassword.Text, Role = "Student" }));

        //    // Step 2: Insert the new student
        //    string insertStudentQuery = "INSERT INTO students (first_name, middle_name, last_name, age, sex, user_id) VALUES (@FirstName, @MiddleName, @LastName, @Age, @Sex, @UserId); SELECT last_insert_rowid();";
        //    var studentId = dbController.Execute(conn => conn.ExecuteScalar<int>(insertStudentQuery, new { FirstName = txtFName.Text, MiddleName = txtMName.Text, LastName = txtLName.Text, Age = txtAge.Text, Sex = cmbSex.SelectedItem, UserId = userId }));

        //    // Add to the students list
        //    students.Add(new Student
        //    {
        //        StudentId = studentId,
        //        FirstName = txtFName.Text,
        //        MiddleName = txtMName.Text,
        //        LastName = txtLName.Text,
        //        Age = int.Parse(txtAge.Text),
        //        Sex = cmbSex.SelectedItem?.ToString(),
        //        UserId = userId
        //    });
        //    await RefreshDataAsync();
        //    MessageBox.Show("Student added successfully!");
        //}

        //private async void OnUpdateStudent(object sender, EventArgs e)
        //{
        //    string updateStudentQuery = @"
        //    UPDATE students 
        //    SET first_name = @FirstName, middle_name = @MiddleName, last_name = @LastName, age = @Age, sex = @Sex 
        //    WHERE student_id = @StudentId;";
        //    dbController.Execute(conn =>
        //        conn.Execute(updateStudentQuery, new
        //        {
        //            FirstName = txtFName.Text,
        //            MiddleName = txtMName.Text,
        //            LastName = txtLName.Text,
        //            Age = txtAge.Text,
        //            Sex = cmbSex.SelectedItem,
        //            StudentId = selectedStudentId
        //        }));
        //    string updateUserStudentQuery = @"
        //    UPDATE users 
        //    SET username = @Username, password = @Password
        //    WHERE user_id = @UserID;";
        //    dbController.Execute(conn =>
        //        conn.Execute(updateUserStudentQuery, new
        //        {
        //            Username = txtUsername.Text,
        //            Password = txtPassword.Text,
        //            studentUser?.UserID
        //        }));

        //    // Update in the students list
        //    var student = students.FirstOrDefault(s => s.StudentId == selectedStudentId);
        //    if (student != null)
        //    {
        //        student.FirstName = txtFName.Text;
        //        student.MiddleName = txtMName.Text;
        //        student.LastName = txtLName.Text;
        //        student.Age = int.Parse(txtAge.Text);
        //        student.Sex = cmbSex.SelectedItem?.ToString();
        //    }

        //    await RefreshDataAsync();
        //    MessageBox.Show("Student updated successfully!");
        //}

        private async void OnDeleteStudent(long studentID, int userID)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                // Delete student record query
                string deleteStudentQuery = "DELETE FROM students WHERE student_id = @StudentID;";
                string deleteUserQuery = "DELETE FROM users WHERE user_id = @UserID;";
                // Execute the delete query using Dapper
                using (var connection = dbController.GetConnection())
                {
                    await connection.ExecuteAsync(deleteStudentQuery, new { StudentID = studentID });
                    await connection.ExecuteAsync(deleteUserQuery, new { UserID = userID });
                }

                // Refresh the DataGridView
                await RefreshDataAsync();

                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnChangePic(object sender, EventArgs e)
        {

            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            openFileDialog.Title = "Select a Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image
                Image? selectedImage = Image.FromFile(openFileDialog.FileName);

                // Store the image in the database
                imageController?.SaveImageToDatabase(imageController.ImageToByteArray(selectedImage));

                // Update the PictureBox to display the new image
                picProfile.Image = selectedImage;
                MessageBox.Show("Profile picture updated successfully!");
            }
        }

        private void OnSearch(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string searchQuery = @"
                    SELECT student_id AS StudentId, first_name AS FirstName, middle_name AS MiddleName, 
                        last_name AS LastName, age AS Age, sex AS Sex, user_id AS UserId 
                    FROM students
                    WHERE first_name LIKE @SearchTerm
                        OR middle_name LIKE @SearchTerm
                        OR last_name LIKE @SearchTerm
                        OR sex LIKE @SearchTerm
                        OR CAST(age AS TEXT) LIKE @SearchTerm
                        OR CAST(student_id AS TEXT) LIKE @SearchTerm";
                    var result = dbController.Execute(conn =>
                    conn.Query<Student>(searchQuery, new { SearchTerm = $"%{textBox.Text}%" }).ToList());
                    if (result.Count != 0)
                    {
                        foreach (var item in result)
                        {
                            Debug.WriteLine(item.FirstName);

                        }
                        studentList = result;
                        gridStudents.DataSource = studentList;
                    }
                    else
                    {
                        gridStudents.DataSource = null;
                    }
                }
                else
                {
                    studentList = dbController.Execute(conn => conn.Query<Student>("SELECT student_id AS StudentId, first_name AS FirstName, middle_name AS MiddleName, last_name AS LastName, age AS Age, sex AS Sex, user_id AS UserId FROM students").ToList());
                    gridStudents.DataSource = studentList;
                }
            }
        }
        private async void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridStudents.Columns["Delete"].Index && e.RowIndex != -1)
            {
                // Get the student ID from the clicked row
                var studentId = Convert.ToInt64(gridStudents.Rows[e.RowIndex].Cells["StudentId"].Value);

                foreach (var student in studentList)
                {
                    if (student.StudentId == studentId)
                    {
                        OnDeleteStudent(studentId, student.UserId);
                    }
                }
                // Call the method to delete the student
            }
            else if (e.ColumnIndex == gridStudents.Columns["Edit"].Index && e.RowIndex != -1)
            {
                var studentId = Convert.ToInt64(gridStudents.Rows[e.RowIndex].Cells["StudentId"].Value);
                foreach (var student in studentList)
                {
                    if (student.StudentId == studentId)
                    {
                        //This is where we will open a dialogue to update student using CUStudentForm
                        var ceStudentForm = new CUStudentForm(student);
                        ceStudentForm.ShowDialog();

                        await RefreshDataAsync();
                    }
                }
            }
        }

        private void OnCellHover(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridStudents.Columns["Edit"].Index || e.ColumnIndex == gridStudents.Columns["Delete"].Index)
            {
                if (e.RowIndex != -1)
                {
                    gridStudents.Cursor = Cursors.Hand;
                }
            }
            else
            {
                gridStudents.Cursor = Cursors.Default;
            }

        }

        private void OnCellLeaveHover(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridStudents.Columns["Edit"].Index || e.ColumnIndex == gridStudents.Columns["Delete"].Index)
            {
                if (e.RowIndex != -1)
                {
                    gridStudents.Cursor = Cursors.Default;
                }
            }
        }
        private async void OnColorScheme(object sender, EventArgs e)
        {
            txtSearch.ResetColors();
            await Task.Delay(150);
            if (sender is BunifuImageButton button)
            {
                if (colorSchemeController.ColorMode == ColorScheme.Light)
                {
                    button.Image = Properties.Resources.light_mode;
                    colorSchemeController.ApplyDarkTheme(this, schemeControls);
                }
                else if (colorSchemeController.ColorMode == ColorScheme.Night)
                {
                    button.Image = Properties.Resources.night_mode;
                    colorSchemeController.ApplyLightTheme(this, schemeControls);
                }
            }
        }
        #endregion

        private async void OnAdd(object sender, EventArgs e)
        {
            CUStudentForm cuForm = new();
            cuForm.ShowDialog();

            await RefreshDataAsync();
        }
    }
}
