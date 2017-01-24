using PeaceApp.BLL.Manager.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PeaceApp.Data.Entity.Students;

namespace PeaceApp.UI.Web.Controllers
{
    public class UserController : Controller
    {
        public StudentService StudentService;
        public StudentDTO studentDto;

        public UserController()
        {
            StudentService = new StudentService();
            studentDto = new StudentDTO();
        }

        public ActionResult Home()
        {
            return View();
        }
        // GET: Home
        public ActionResult UserAdd()
        {
            StudentService.Add(new StudentDTO()
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
            return View();
        }

        public ActionResult Update()
        {
            StudentService.Update(new StudentDTO()
            { Id = 2,
            Name = "Serhat",
            LastName = "Davran",
            Age = 40

            });
                
            return View();
        }

        public ActionResult Delete()
        {
            StudentService.Delete(new StudentDTO()
            {
                Id = 3
            });

            return View();
        }
    }
}