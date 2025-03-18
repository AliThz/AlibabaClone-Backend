using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class Role : Framework.Base.Entity<byte>
    {
        public Role() { }

        public required string Title { get; set; }
    }
}
