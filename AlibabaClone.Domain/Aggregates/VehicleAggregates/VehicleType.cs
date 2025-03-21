using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.VehicleAggregates
{
    public class VehicleType : Framework.Base.Entity<short>
    {
        public VehicleType() { }

        public required string Title { get; set; }
    }
}
