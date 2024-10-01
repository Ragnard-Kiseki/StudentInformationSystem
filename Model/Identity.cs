using System.Security.Principal;

namespace Student_Information_System.Model;

internal class Identity(string name) : IIdentity
{
    public string Name { get; } = name;
    public string AuthenticationType => "Custom";
    public bool IsAuthenticated => true;
}