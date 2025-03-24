using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AlibabaClone.Domain.Framework.Interfaces.Repositories.TransactionRepositories
{
    public interface ITransactionRepository : IRepository<Transaction, Guid>
    {
    }
}
