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
            new Student { StudentNumber = "u24782646", Name = "Steyn", Surname = "Coetzee", Email = "u24782646@tuks.co.za", MyLink = "/HTML/Steyn.html" },
            new Student { StudentNumber = "u22786989", Name = "Craig", Surname = "Hasenjager", Email = "u22786989@tuks.co.za", MyLink = "/HTML/Craig.html" },
            new Student { StudentNumber = "u24986986", Name = "Chris", Surname = "Bailey", Email = "u24986986@tuks.co.za", MyLink = "/HTML/Chris.html" },
            new Student { StudentNumber = "u24587568", Name = "Xander", Surname = "Steyn", Email = "u24587568@tuks.co.za", MyLink = "/HTML/Xander.html" },
            new Student { StudentNumber = "u24523565", Name = "Nick", Surname = "Bailey", Email = "u24523565@tuks.co.za", MyLink = "/HTML/Nick.html" }
        };

        public IActionResult Index()
        {
            return View(students);
        }
    }
}
