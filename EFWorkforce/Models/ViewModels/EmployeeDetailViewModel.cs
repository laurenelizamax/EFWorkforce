using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkforce.Models.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int ComputerId { get; set; }
        public bool IsSupervisor { get; set; }
        public string Email { get; set; }

        public Department Department { get; set; }
        public Computer Computer { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
    }
}
