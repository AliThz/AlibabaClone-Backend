using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class Gender : Framework.Base.Entity<short>
    {
        public Gender() {    }

        public required string Title { get; set; }
    }
}
