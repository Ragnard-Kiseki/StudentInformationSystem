using Dapper;
using Student_Information_System.Controller;
using Student_Information_System.Model;
using System.Data;

namespace Student_Information_System.View;

public partial class ManageModForm : Form
{
    #region Fields
    static readonly DBController dbController = new();
    private static Int64 selectedModeratorID;
    static Principal? principal;
    readonly string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Images");
    static ImageController? imageController;
    private Admin? admin = new();
    private List<Moderator> moderators = [];
    private User? moderatorUser;
    #endregion
    public ManageModForm()
    {
        InitializeComponent();
    }
    #region NOCONTROL CONTROLLER
    public static async Task<DataTable> GetDataAsync(string query)
    {
        var dt = new DataTable();

        // Get the connection string from DBController or use directly if preferred
        using var connection = dbController.GetConnection(); // Assuming SQLite connection
        await connection.OpenAsync();

        // Using Dapper to query data asynchronously
        dt.Load(await connection.ExecuteReaderAsync(query)); // Fill the DataTable with the result set

        return dt;
    }

    public async Task RefreshDataAsync()
    {
        var query = "SELECT moderator_id AS ModeratorID, first_name AS FirstName, last_name AS LastName, profile_image as ProfileImage, user_id as UserID FROM moderators";
        gridModerators.DataSource = await GetDataAsync(query);
    }
    #endregion
    private async void OnFormLoad(object sender, EventArgs e)
    {
        principal = (Principal?)Thread.CurrentPrincipal;
        imageController = new(dbController, principal);
        gridModerators.DataSource = moderators;
        gridModerators.AutoGenerateColumns = false;
        gridModerators.Columns["UserID"].Visible = true; // Hide UserId column if not needed
        gridModerators.Columns["ModeratorID"].HeaderText = "Moderator ID";
        gridModerators.Columns["FirstName"].HeaderText = "First Name";
        gridModerators.Columns["LastName"].HeaderText = "Last Name";
        gridModerators.Columns["ProfileImage"].HeaderText = "Profile Picture";
        if (principal?.UserRole == UserRole.Admin)
        {
            lblRole.Text = principal?.UserRole.ToString();
            admin = dbController.Execute(conn =>
            conn.QuerySingleOrDefault<Admin>(
                "SELECT admin_id AS AdminId, profile_image AS ProfileImage, user_id AS UserId FROM admins WHERE user_id = @UserId",
                new { principal?.UserId }
            )
);
            if (admin?.ProfileImage == null)
            {
                imageController.SaveImageToDatabase(imageController.ImageToByteArray(Image.FromFile(Path.Combine(imagePath, "admin.png"))));
                imageController.LoadProfileImage(picProfile);
            }
            else
            {
                imageController.LoadProfileImage(picProfile);
            }
        }
        else
        {
            MessageBox.Show("Who are you?");
            Close();
        }
        await RefreshDataAsync();
    }
    void OnSelectionChange(object sender, EventArgs e)
    {

    }

    //private async void OnCreateModerator(object sender, EventArgs e)
    //{
    //    // Step 1: Insert the new user and get the user_id
    //    string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@Username, @Password, @Role); SELECT last_insert_rowid();";
    //    var userId = dbController.Execute(conn => conn.ExecuteScalar<int>(insertUserQuery, new { Username = txtUsername.Text, Password = txtPassword.Text, Role = "Moderator" }));

    //    // Step 2: Insert the new student
    //    string insertModeratorQuery = "INSERT INTO moderators (first_name, last_name, profile_image, user_id) VALUES (@FirstName, @LastName, @ProfileImage, @UserId); SELECT last_insert_rowid();";
    //    var moderatorID = dbController.Execute(conn => conn.ExecuteScalar<int>(insertModeratorQuery, new { FirstName = txtFName.Text, LastName = txtLName.Text, ProfileImage = imageController?.ImageToByteArray(imgHolder.Image), UserId = userId }));

    //    // Add to the students list
    //    moderators.Add(new Moderator
    //    {
    //        ModeratorID = moderatorID,
    //        FirstName = txtFName.Text,
    //        LastName = txtLName.Text,
    //        ProfileImage = imageController?.ImageToByteArray(imgHolder.Image),
    //        UserId = userId
    //    });
    //    await RefreshDataAsync();
    //    MessageBox.Show("Student added successfully!");
    //}

    //private void OnSetImage(object sender, EventArgs e)
    //{
    //    using OpenFileDialog openFileDialog = new();
    //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
    //    openFileDialog.Title = "Select a Profile Picture";

    //    if (openFileDialog.ShowDialog() == DialogResult.OK)
    //    {
    //        // Load the selected image
    //        Image selectedImage = Image.FromFile(openFileDialog.FileName);
    //        // Update the PictureBox to display the new image
    //        imgHolder.Image = selectedImage;
    //    }
    //}
}