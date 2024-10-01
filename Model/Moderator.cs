namespace Student_Information_System.Model
{
    internal class Moderator
    {
        public int ModeratorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public byte[]? ProfileImage { get; set; }
        public int UserId { get; set; }
    }
}
