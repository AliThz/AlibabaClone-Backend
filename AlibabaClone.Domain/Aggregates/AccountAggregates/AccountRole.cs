using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class AccountRole
    {
        public AccountRole() {    }

        public Guid AccountId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
