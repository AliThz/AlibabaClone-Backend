using AlibabaClone.Domain.Aggregates.AccountsAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.AccountConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.Property(a => a.Password)
                   .IsRequired()
                   .HasMaxLength(100);


            builder.Property(a => a.Email)
                   .HasMaxLength(100);

            builder.HasOne(a => a.Person)
                   .WithMany(p => p.Accounts)
                   .HasForeignKey(a => a.PersonId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
