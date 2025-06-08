using HealthCareDemoDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareDemoDataAccess
{
    public class HealthCareRepostory
    {
        private HealthCareContext _context;
        public HealthCareRepostory(HealthCareContext context)
        {
            _context = context;
        }
        public List<staff> GetAllStaffDetails()
        {
            //var staffList = (from staffListDb in _context.staff select staffListDb).ToList();
            var staffList = _context.staff.ToList();
            return staffList;
        }
    }
}
