namespace FinalProjectWebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Program { get; set; }
        public string YearInProgram { get; set; }
        public Student() { }
        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, string program, string yearInProgram)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Program = program;
            YearInProgram = yearInProgram;
        }
    }
}
