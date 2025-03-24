using AlibabaClone.Domain.Aggregates.CompanyAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.CompanyRepositories
{
    public interface ICompanyRepository : IRepository<Company, Guid>
    {
    }
}
