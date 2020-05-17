using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }
        public int NumberofDays { get; set; }
        public DateTime DateCreated { get; set; }
        public LeaveTypeViewModel Leave { get; set; }
        public EmployeeViewModel Employee { get; set; }
    }
}
