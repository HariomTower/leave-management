using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repositories
{
    public class LeaveAllocationRepository : RepositoryBase<LeaveAllocation>
    {
        public LeaveAllocationRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

       
    }
}
