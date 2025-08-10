using System;

namespace UsersReyestr.Web.Models.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Gpa { get; set; }
        public string GroupName { get; set; }
        public string Faculty { get; set; }
        public string Gender { get; set; }
        public int Course { get; set; }
        public DateTimeOffset EnrollmentDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
