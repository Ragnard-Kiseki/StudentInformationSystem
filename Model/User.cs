namespace Student_Information_System.Model;

public enum UserRole
{
    Admin,
    Moderator,
    Student
}

internal class User
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required Int64 UserID { get; set; }
    public UserRole Role { get; set; }
}