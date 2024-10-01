using Student_Information_System.Controller;
using Student_Information_System.Model;

namespace Student_Information_System.View
{
    public partial class LoginForm : Form
    {
        private readonly DBController dbController;
        private readonly ColorSchemeController colorSchemeController = new();

        public LoginForm()
        {
            InitializeComponent();
            dbController = new DBController();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            // Validate user credentials and get the role
            var (userRole, userId) = dbController.ValidateUser(username, password);

            if (userRole.HasValue && userId.HasValue)
            {
                var principal = new Principal(username, userRole.Value, userId.Value);
                Thread.CurrentPrincipal = principal;
                MainForm mainForm = new();
                Hide();
                mainForm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            List<Control> controls = [
                pnlTitle,pnlContent,pnlContentTitle,btnLogin,txtPassword,txtUsername,ctrlClose,ctrlMin
                ];
            colorSchemeController.ApplyLightTheme(this, controls);
        }
    }
}