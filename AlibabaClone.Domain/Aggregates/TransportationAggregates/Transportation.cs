using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransportationAggregates
{
    public class Transportation : Framework.Base.Entity<Guid>
    {
        public Transportation() { }

        public Guid FromLocationId { get; set; }
        public Guid ToLocationId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid VehicleId { get; set; }

        public virtual LocationAggregates.Location FromLocation { get; set; }
        public virtual LocationAggregates.Location ToLocation { get; set; }
        public virtual CompanyAggregates.Company Company { get; set; }
        public virtual VehicleAggregates.Vehicle Vehicle { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
