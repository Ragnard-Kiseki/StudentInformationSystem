using Bunifu.UI.WinForms;
using Dapper;
using Student_Information_System.Model;

namespace Student_Information_System.Controller
{
    internal class ImageController(DBController dbController, Principal? principal)
    {

#pragma warning disable CA1822 // Mark members as static
        public byte[] ImageToByteArray(Image image)
#pragma warning restore CA1822 // Mark members as static
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }
#pragma warning disable CA1822 // Mark members as static
        public Image ByteArrayToImage(byte[] imageBytes)
#pragma warning restore CA1822 // Mark members as static
        {
            using var ms = new MemoryStream(imageBytes);
            return Image.FromStream(ms);
        }
        public void SaveImageToDatabase(byte[] imageBytes)
        {
            string updateQuery = "";
            if (principal?.UserRole == UserRole.Admin)
            {
                updateQuery = "UPDATE admins SET profile_image = @ProfileImage WHERE user_id = @UserId";
            }
            else if (principal?.UserRole == UserRole.Moderator)
            {
                updateQuery = "UPDATE moderators SET profile_image = @ProfileImage WHERE user_id = @UserId";
            }
            else
            {
                MessageBox.Show("Who are you?");
            }

            dbController.Execute(conn => conn.Execute(updateQuery, new { ProfileImage = imageBytes, principal?.UserId }));
        }
        public void LoadProfileImage(BunifuPictureBox picBox)
        {
            string selectQuery = "";
            if (principal?.UserRole == UserRole.Admin)
            {
                selectQuery = "SELECT profile_image FROM admins WHERE user_id = @UserId";
            }
            else if (principal?.UserRole == UserRole.Moderator)
            {
                selectQuery = "SELECT profile_image FROM moderators WHERE user_id = @UserId";
            }
            else
            {
                MessageBox.Show("Who are you?");
            }
            var imageBytes = dbController.Execute(conn => conn.QuerySingleOrDefault<byte[]>(selectQuery, new { principal?.UserId }));
            if (imageBytes != null)
            {
                picBox.Image = ByteArrayToImage(imageBytes);
            }
            else
            {
                MessageBox.Show("No profile picture found.");
            }
        }
        public void LoadProfileImage(BunifuImageButton picBox)
        {
            string selectQuery = "";
            if (principal?.UserRole == UserRole.Admin)
            {
                selectQuery = "SELECT profile_image FROM admins WHERE user_id = @UserId";
            }
            else if (principal?.UserRole == UserRole.Moderator)
            {
                selectQuery = "SELECT profile_image FROM moderators WHERE user_id = @UserId";
            }
            else
            {
                MessageBox.Show("Who are you?");
            }
            var imageBytes = dbController.Execute(conn => conn.QuerySingleOrDefault<byte[]>(selectQuery, new { principal?.UserId }));
            if (imageBytes != null)
            {
                picBox.Image = ByteArrayToImage(imageBytes);
            }
            else
            {
                MessageBox.Show("No profile picture found.");
            }
        }
    }
}
