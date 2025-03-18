using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransportationAggregates
{
    public class TicketStatus : Framework.Base.Entity<byte>
    {
        public TicketStatus() { }

        public required string Title { get; set; }
    }
}
