using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryUI.Mvc.Areas.Hrm.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage ="Department Name is Required !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Department Name Bangla is Required !")]
        public string NameInBangla { get; set; }
        public string IsActive { get; set; }
    }
}
