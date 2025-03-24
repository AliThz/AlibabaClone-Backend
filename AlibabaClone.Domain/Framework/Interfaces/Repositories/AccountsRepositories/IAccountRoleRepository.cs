using AlibabaClone.Domain.Aggregates.AccountsAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.AccountRepositories
{
    public interface IAccountRoleRepository : IRepository<AccountRole, Guid>
    {
    }
}
