using AlibabaClone.Domain.Aggregates.AccountsAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.AccountConfigurations
{
    public class AccountRoleConfiguration : IEntityTypeConfiguration<AccountRole>
    {
        public void Configure(EntityTypeBuilder<AccountRole> builder)
        {
            builder.ToTable("AccountRole");
            builder.HasKey(ar => new {ar.AccountId, ar.RoleId})

            builder.HasOne<Account>()
                   .WithMany()
                   .HasForeignKey(ar => ar.RoleId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Role>()
                   .WithMany()
                   .HasForeignKey(ar => ar.AccountId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}