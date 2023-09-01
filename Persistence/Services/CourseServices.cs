using Persistence.Contexts;
using Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class CourseServices :ICourseServices
    {
        private readonly ApplicationDbContext _context;

        public CourseServices(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
