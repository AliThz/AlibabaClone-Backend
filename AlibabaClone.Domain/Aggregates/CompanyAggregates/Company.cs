using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.CompanyAggregates
{
    public class Company : Framework.Base.Entity<Guid>
    {
        public Company() { }

        public required string Title { get; set; }
        public virtual ICollection<TransportationAggregates.Transportation> Transportations { get; set; }
    }
}
