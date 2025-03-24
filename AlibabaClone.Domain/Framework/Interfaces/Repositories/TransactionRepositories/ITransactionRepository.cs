using AlibabaClone.Domain.Aggregates.TransactionAggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.TransactionRepositories
{
    public interface ITransactionRepository : IRepository<Transaction, Guid>
    {
    }
}
