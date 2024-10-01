using System.Security.Principal;

namespace Student_Information_System.Model;

internal class Principal(string name, UserRole role, Int64 userId) : IPrincipal
{
    public IIdentity Identity { get; } = new GenericIdentity(name);
    public UserRole UserRole { get; } = role;
    public Int64 UserId { get; } = userId;

    // Implement the IsInRole method to use the UserRole enum
    public bool IsInRole(string role)
    {
        // Convert the string to UserRole and compare
        if (Enum.TryParse(role, out UserRole userRole))
        {
            return UserRole == userRole;
        }
        return false; // Return false if the conversion fails
    }

    // Optional: Overloaded method for UserRole enum
    public bool IsInRole(UserRole role)
    {
        return UserRole == role;
    }
}