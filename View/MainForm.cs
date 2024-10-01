using Bunifu.UI.WinForms;
using Dapper;
using Student_Information_System.Controller;
using Student_Information_System.Model;

namespace Student_Information_System.View
{
    public partial class MainForm : Form
    {
        static Principal? principal;
        static readonly DBController dbController = new();
        static ImageController? imageController;
        readonly ManageStudentForm manageStudForm = new();
        readonly ColorSchemeController colorSchemeController = new();
        private Admin? admin = new();
        private Moderator? moderator = new();
        readonly ManageModForm manageModForm = new();
        List<Control> schemeControls = [];
        readonly string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Images");
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            principal = (Principal?)Thread.CurrentPrincipal;
            imageController = new(dbController, principal);
            schemeControls =
            [
                pnlUser, pnlTitle, pnlContent, btnMngStud, btnMngMod,picProfile,ctrlClose,imgScheme,ctrlMin
            ];
            if (colorSchemeController.ColorMode == ColorScheme.Light)
            {
                colorSchemeController.ApplyLightTheme(this, schemeControls);
            }
            else
            {
                colorSchemeController.ApplyDarkTheme(this, schemeControls);
            }
            if (principal != null)
            {
                switch (principal.UserRole)
                {
                    case UserRole.Admin:
                        btnMngMod.Visible = true;
                        btnMngStud.Visible = true;
                        lblName.Visible = false;
                        admin = dbController.Execute(conn =>
                            conn.QuerySingleOrDefault<Admin>(
                                "SELECT admin_id AS AdminId, profile_image AS ProfileImage, user_id AS UserId FROM admins WHERE user_id = @UserId",
                                new { principal.UserId }
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
                        lblRole.ForeColor = Color.Red;
                        break;
                    case UserRole.Moderator:
                        btnMngMod.Visible = false;
                        btnMngStud.Visible = true;
                        lblName.Visible = true;
                        tableLayoutPanel3.ColumnCount = 1;
                        btnMngStud.Margin = new Padding(0, 25, 0, 0);
                        tableLayoutPanel3.SetColumn(btnMngStud, 0);
                        moderator = dbController.Execute(conn =>
                        conn.QuerySingleOrDefault<Moderator>(
                                "SELECT moderator_id AS ModeratorId, first_name AS FirstName, last_name AS LastName, profile_image AS ProfileImage, user_id AS UserId FROM moderators WHERE user_id = @UserId",
                                new { principal.UserId }
                            )
                        );
                        lblName.Text = $"{moderator?.FirstName} {moderator?.LastName}";
                        if (moderator?.ProfileImage == null)
                        {
                            imageController.SaveImageToDatabase(imageController.ImageToByteArray(Image.FromFile(Path.Combine(imagePath, "moderator.png"))));
                            imageController.LoadProfileImage(picProfile);
                        }
                        else
                        {
                            imageController.LoadProfileImage(picProfile);
                        }
                        lblRole.ForeColor = Color.Yellow;
                        break;
                    case UserRole.Student:
                        break;
                    default:
                        MessageBox.Show("Who are you?");
                        break;
                }
                lblRole.Text = principal.UserRole.ToString();
            }
        }
        private void OnManageStud(object sender, EventArgs e)
        {
            Hide();
            manageStudForm.ShowDialog();
            Show();
        }
        private void OnManageMod(object sender, EventArgs e)
        {
            Hide();
            manageModForm.ShowDialog();
            Show();
        }
        private void OnColorScheme(object sender, EventArgs e)
        {
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
    }
}

