using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.TransactionAggregates
{
    public class Coupon : Framework.Base.Entity<Guid>
    {
        public Coupon() {    }

        public string Code { get; set; }
        public int Percentage { get; set; }
        public decimal MaxDiscount { get; set; }
        public decimal MinBaseAmount { get; set; }
        public string? Descrption { get; set; }
        public Guid? AccountId { get; set; }

        public virtual AccountsAggregates.Account? Account { get; set; }
    }
}
