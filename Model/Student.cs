namespace Student_Information_System.Model
{
    public class Student
    {
        public Int64 StudentId { get; set; }
        public byte[]? ProfileImage { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public int UserId { get; set; }
    }
}
