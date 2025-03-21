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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(r => r.Title)
                   .IsRequired()
                   .HasMaxLength(63);
            builder.HasIndex(r => r.Title)
                   .IsUnique();

        }
    }
}