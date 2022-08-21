using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }

        public IActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id=2,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    Id=2,
                    FirstName = "Brett",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    Id=2,
                    FirstName = "Adam",
                    LastName = "Smithsonian"
                }
            };
            return View(instructors);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}