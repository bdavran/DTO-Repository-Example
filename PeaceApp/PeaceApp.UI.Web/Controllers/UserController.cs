using PeaceApp.BLL.Manager.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeaceApp.UI.Web.Controllers
{
    public class UserController : Controller
    {
        public StudentService StudentService;

        public UserController()
        {
            StudentService = new StudentService();
        }

        // GET: Home
        public ActionResult UserAdd()
        {
            StudentService.Add(new Data.Entity.Students.StudentDTO()
            {
                Name = "Barış",
                LastName = "Davran",
                Age = 50
            });

            return View();
        }

        public ActionResult List()
        {
            StudentService.GetAllUSer();
        }
    }
}