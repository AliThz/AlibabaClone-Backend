using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.LocationAggregates
{
    public class Location : Framework.Base.Entity<Guid>
    {
        public Location() { }

        public required string Title { get; set; }
        public Guid CityId { get; set; }
        public short LocationTypeId { get; set; }

        public virtual City City { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual ICollection<TransportationAggregates.Transportation> Transportations { get; set; }
    }
}
