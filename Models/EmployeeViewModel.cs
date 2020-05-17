using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TextId { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoined { get; set; }
    }
}
