namespace Student_Informations_23_10
{
    public  class Student
    {

        private static int _id ;
        public int Id { get;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public StudentStatus StudentStatus { get; set; }
        public double GPA {  get; set; }
        public string Major {  get; set; }
        public Student( string firstName, string lastName, string email, string phoneNumber, double gPA, string major)
        {
            _id++;
            Id = _id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            GPA = gPA;
            Major = major;
            StudentStatus = StudentStatus.Pending;
        }
    }
}

public enum StudentStatus : byte
{
    Active = 1,
    Graduate = 2,
    Pending = 3,
    Removed = 4
}
