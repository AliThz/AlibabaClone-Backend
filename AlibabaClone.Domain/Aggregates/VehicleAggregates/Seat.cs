using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.VehicleAggregates
{
    public class Seat : Framework.Base.Entity<Guid>
    {
        public Seat() { }

        public Guid VehicleId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsVIP { get; set; }
        public bool IsAvailable { get; set; }
        public string? Description { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
