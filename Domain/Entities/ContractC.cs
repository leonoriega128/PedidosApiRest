using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContractC : AuditableBaseEntity
    {
        public int ContractId { get; set; }
        public int ItemId { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
        public DateTime UpdateDate { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
    }
}
