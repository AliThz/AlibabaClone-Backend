using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransactionAggregates
{
    public class Transaction : Framework.Base.Entity<Guid>
    {
        public Transaction() { }

        public Guid TicketId { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public string SerialNumber { get; set; }
        public Guid? CouponId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Coupon? Coupon { get; set; }
    }
}
