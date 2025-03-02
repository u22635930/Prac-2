using Microsoft.AspNetCore.Mvc;
using CraigStudyGroup.Models;
using System.Collections.Generic;

namespace CraigStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // Static list to hold student data (no database needed)
        private static List<Student> students = new List<Student>
        {
            new Student("u01234567", "Craig", "Hasenjager", "u22635930@tuks.co.za"),
            new Student("u12345678", "Steyn", "Coetzee", "12345678@tuks.co.za"),
            new Student("u23456789", "Alice", "Steyn", "23456789@tuks.co.za"),
            new Student("u34567890", "Bob", "Dylan", "34567890@tuks.co.za"),
            new Student("u45678901", "Eve", "Adam", "45678901@tuks.co.za")
        };

        public IActionResult Index()
        {
            return View(students);
        }
    }
}
