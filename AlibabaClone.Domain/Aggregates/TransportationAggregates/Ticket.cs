using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransportationAggregates
{
    public class Ticket : Framework.Base.Entity<Guid>
    {
        public Ticket() {   }

        public Guid TransportationId { get; set; }
        public Guid SeatId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid TravelerId { get; set; }
        public Guid? CompanionId { get; set; }
        public byte TicketStatusId { get; set; }
        public string SerialNumber { get; set; }
        public string? Description { get; set; }

        public virtual Transportation Transportation { get; set; }
        public virtual VehicleAggregates.Seat Seat { get; set; }
        public virtual AccountsAggregates.Person Buyer { get; set; }
        public virtual AccountsAggregates.Person Traveler { get; set; }
        public virtual AccountsAggregates.Person? Companion { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }
    }
}
