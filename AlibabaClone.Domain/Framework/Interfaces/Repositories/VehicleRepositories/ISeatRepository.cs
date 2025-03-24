using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.VehicleRepositories
{
    public interface ISeatRepository : IRepository<Seat, Guid>
    {
    }
}
