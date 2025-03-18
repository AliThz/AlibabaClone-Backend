using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Framework.Base
{
    public class Entity<TKey> : Interfaces.IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
