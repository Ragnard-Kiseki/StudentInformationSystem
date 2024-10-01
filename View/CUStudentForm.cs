using Bunifu.UI.WinForms;
using Dapper;
using Guna.UI2.WinForms;
using Student_Information_System.Controller;
using Student_Information_System.Model;

namespace Student_Information_System.View
{
    public partial class CUStudentForm : Form
    {

        #region Fields
        static readonly Random random = new Random();
        private readonly Student? student;
        static Principal? principal;
        static readonly DBController dbController = new();
        readonly ColorSchemeController colorSchemeController = new();
        static ImageController? imageController;
        List<Control> schemeControls = [];
        readonly string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Images");

        #endregion
        public CUStudentForm(Student? _student = null)
        {
            student = _student;
            InitializeComponent();
        }

        #region NOCONTROL CONTROLLER
        static string GenerateUsername(string firstName)
        {
            // Generate a random number (between 100 and 999)
            int randomNumber = random.Next(100, 1000);
            // Combine the name and random number
            string username = $"{firstName}_{randomNumber}";

            if (username.Length >= 10)
            {
                username = username[..9];
            }

            return username;
        }
        #endregion

        private void OnFormLoad(object sender, EventArgs e)
        {
            principal = (Principal?)Thread.CurrentPrincipal;
            if (principal?.UserRole == UserRole.Admin || principal?.UserRole == UserRole.Moderator)
            {
                imageController = new(dbController, principal);
                txtFName.ResetColors();
                txtMName.ResetColors();
                txtLName.ResetColors();
                txtAge.ResetColors();
                schemeControls = [
                pnlTitle,pnlUser,pnlContent,ctrlClose,ctrlMin,btnCU,picProfile,imgScheme,txtAge,txtFName,txtLName,txtMName,cmbSex
                    ];
                if (colorSchemeController.ColorMode == ColorScheme.Light)
                {
                    colorSchemeController.ApplyLightTheme(this, schemeControls);
                }
                else
                {
                    colorSchemeController.ApplyDarkTheme(this, schemeControls);
                }
                if (student != null)
                {
                    if (student.ProfileImage == null)
                    {
                        picProfile.Image = Image.FromFile(Path.Combine(imagePath, "student.png"));
                    }
                    else
                    {
                        picProfile.Image = imageController.ByteArrayToImage(student.ProfileImage);
                    }

                    txtFName.Text = student.FirstName;
                    txtMName.Text = student.MiddleName;
                    txtLName.Text = student.LastName;
                    txtAge.Text = student.Age.ToString();
                    cmbSex.SelectedItem = student.Sex;
                    lblName.Text = $"{student.LastName}, {student.FirstName} {student.MiddleName}";
                    lblRole.Text = "Student";
                    lblRole.ForeColor = Color.Blue;
                }
                else
                {
                    lblTitle.Text = "Add Student";
                    btnCU.Text = "A D D";
                    lblName.Visible = false;
                    lblRole.Visible = false;
                    picProfile.Image = Image.FromFile(Path.Combine(imagePath, "student.png"));
                }
            }
        }

        private async void OnColorScheme(object sender, EventArgs e)
        {
            txtFName.ResetColors();
            txtMName.ResetColors();
            txtLName.ResetColors();
            txtAge.ResetColors();
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

        private void OnCU(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (student != null)
                {
                    string updateStudentQuery = @"
                    UPDATE students 
                    SET first_name = @FirstName, middle_name = @MiddleName, last_name = @LastName, age = @Age, sex = @Sex, profile_image = @ProfileImage WHERE student_id = @StudentId;";
                    dbController.Execute(conn =>
                        conn.Execute(updateStudentQuery, new
                        {
                            FirstName = txtFName.Text,
                            MiddleName = txtMName.Text,
                            LastName = txtLName.Text,
                            Age = txtAge.Text,
                            Sex = cmbSex.SelectedItem,
                            ProfileImage = imageController?.ImageToByteArray(picProfile.Image),
                            student.StudentId
                        }));
                    Close();
                }
                else
                {
                    string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@Username, @Password, @Role); SELECT last_insert_rowid();";
                    var userId = dbController.Execute(conn => conn.ExecuteScalar<int>(insertUserQuery, new { Username = GenerateUsername(txtFName.Text), Password = "123", Role = "Student" }));

                    string insertStudentQuery = "INSERT INTO students (profile_image, first_name, middle_name, last_name, age, sex, user_id) VALUES (@ProfileImage, @FirstName, @MiddleName, @LastName, @Age, @Sex, @UserId); SELECT last_insert_rowid();";
                    var studentId = dbController.Execute(conn => conn.ExecuteScalar<int>(insertStudentQuery, new { ProfileImage = imageController?.ImageToByteArray(picProfile.Image), FirstName = txtFName.Text, MiddleName = txtMName.Text, LastName = txtLName.Text, Age = txtAge.Text, Sex = cmbSex.SelectedItem, UserId = userId }));
                    Close();
                }
            }
        }

        private void OnImageChange(object sender, EventArgs e)
        {
            if (sender is BunifuImageButton image_button)
            {
                using OpenFileDialog openFileDialog = new();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);

                    // Update the PictureBox to display the new image
                    image_button.Image = selectedImage;
                    MessageBox.Show("Profile picture updated successfully!");
                }
            }
        }
    }
}
