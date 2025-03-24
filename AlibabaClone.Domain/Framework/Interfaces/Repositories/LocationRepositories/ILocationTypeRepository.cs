using AlibabaClone.Domain.Aggregates.LocationAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.LocationRepositories
{
    public interface ILocationTypeRepository : IRepository<LocationType, short>
    {
    }
}
