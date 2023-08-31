using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DressItem : AuditableBaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
