using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class Gender : Framework.Base.Entity<byte>
    {
        public Gender() {    }

        public string Title { get; set; }
    }
}
