using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkforce.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        public int DepartmentId { get; set; }

        [Display(Name = "Is Supervisor")]
        public bool IsSupervisor { get; set; }
        public int ComputerId { get; set; }
        public Department Department { get; set; }
        public Computer  Computer { get; set; }
        public string  Email { get; set; }
    }
}
