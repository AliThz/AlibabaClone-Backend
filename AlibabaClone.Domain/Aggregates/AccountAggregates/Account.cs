using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class Account : Framework.Base.Entity<Guid>
    {
        public Account() {   }

        public Guid PersonId { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }

        public virtual Person? Person { get; set; }
    }
}
