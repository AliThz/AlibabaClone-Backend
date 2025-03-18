using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.LocationAggregates
{
    public class City : Framework.Base.Entity<Guid>
    {
        public City() { }

        public required string Title { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
