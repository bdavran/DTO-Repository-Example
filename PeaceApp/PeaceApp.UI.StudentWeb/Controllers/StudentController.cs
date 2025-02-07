﻿using PeaceApp.BLL.Manager.Students;
using PeaceApp.Data.Entity.Students;
using PeaceApp.UI.StudentWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeaceApp.Data.Context;

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
                StudentsList = studentService.GetAll()
                
            };

            return View(studentViewModel);
        }
       
        [HttpPost]
        public ActionResult Delete(int studentId)
        {
            var delete = studentService.Delete(studentId);

            return View(delete);
        }

        public ViewResult Add()
        {
            return View(new StudentDTO());
        }

        [HttpPost]
        public ActionResult Add(StudentDTO student)
        {
            var addStudent = studentService.Add(student);
            
            
            return View(addStudent);
        }

        public ActionResult Update(int studentId)
        {
            var student = studentService.Get(studentId);

            return View(student);
        }



        [HttpPost]
        public ActionResult Update(StudentDTO studentDto)
        {
            studentService.Update(studentDto);
            return RedirectToAction("Index");
           
        }

    }
}