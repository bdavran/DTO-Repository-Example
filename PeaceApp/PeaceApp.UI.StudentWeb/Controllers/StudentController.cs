using PeaceApp.BLL.Manager.Students;
using PeaceApp.Data.Entity.Students;
using PeaceApp.UI.StudentWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeaceApp.UI.StudentWeb.Controllers
{
    public class StudentController : Controller
    {
        private StudentService studentService;

        public StudentController()
        {
            studentService = new StudentService();
        }

        public ActionResult Index()
        {           

            var studentViewModel = new StudentViewModel()
            {
                Students = studentService.GetAll()
                
            };

            return View(studentViewModel);
        }
        public ActionResult Delete()
        {
            studentService.Delete(5);

            return View();
        }

        public ViewResult Add()
        {
            return View(new StudentDTO());
        }

        [HttpPost]
        public ActionResult Add(StudentDTO student)
        {

            
            studentService.Add(student);
            
            return View();
        }

    }
}