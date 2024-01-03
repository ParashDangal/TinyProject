using Microsoft.AspNetCore.Mvc;
using TinyProject.DataContext;
using TinyProject.Models;
using TinyProject.Models.Domain;

namespace TinyProject.Controllers
{
    public class StudentController:Controller
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentViewModel studentVm)
        {
            var student = new StudentModel()
            {
                Name = studentVm.Name,
                Address = studentVm.Address,
                Email = studentVm.Email,
                Phone = studentVm.Phone,
            };
            _studentDbContext.Students.Add(student);
            _studentDbContext.SaveChanges();

            return RedirectToAction("ViewStudent");
        }
        public IActionResult ViewStudent()
        {
            var student = _studentDbContext.Students.ToList();
            return View(student);
        }
    }
}
