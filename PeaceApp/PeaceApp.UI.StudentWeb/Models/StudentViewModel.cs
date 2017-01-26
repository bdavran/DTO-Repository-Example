using PeaceApp.Data.Entity.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeaceApp.UI.StudentWeb.Models
{
    public class StudentViewModel
    {
        public IEnumerable<StudentDTO> Students { get; set; }
        

       

    }
}