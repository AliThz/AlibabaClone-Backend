using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Domain.Aggregates.AccountsAggregates
{
    public class Person : Framework.Base.Entity<Guid>
    {
        public Person() {    }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string IdNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public short GenderId { get; set; }
        public string? PassportNumber { get; set; }
        public string? EnglishFirstName { get; set; }
        public string? EnglishLastName { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<TransportationAggregates.Ticket> TraveledTickets { get; set; }
    }
}
