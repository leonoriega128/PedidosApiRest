using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course : AuditableBaseEntity
    {
        public string CourseCode { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool State { get; set; }
        public int NumberGraduates { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryMedium { get; set;}
        public string Seller { get; set; }
        public string CollegeLevel { get; set; }
        public string CollegeName { get; set; }
        public string CollegeCourse { get; set; }
        public string SchoolLocation { get; set; }
        public int Commission { get ; set; }
        public double Total { get; set; }
    }
}
