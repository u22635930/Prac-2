using System.ComponentModel.DataAnnotations;

namespace CraigStudyGroup.Models
{
    public class Student
    {
        [Required]
        [StringLength(10, MinimumLength = 8)]
        public string StudentNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Surname { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Constructor
        public Student(string studentNumber, string name, string surname, string email)
        {
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            Email = email;
        }

        // Default constructor (needed for MVC model binding)
        public Student() { }
    }
}

