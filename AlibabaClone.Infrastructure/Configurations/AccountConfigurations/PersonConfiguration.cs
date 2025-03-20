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
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                   .IsRequired()
                   .HasMaxLength(63);

            builder.Property(p => p.LastName)
                   .IsRequired()
                   .HasMaxLength(63);

            builder.Property(p => p.IdNumber)
                   .IsRequired()
                   .IsUnicode(false)
                   .HasMaxLength(10);
            builder.HasIndex(p => p.IdNumber)
                   .IsUnique();

            builder.Property(p => p.PassportNumber)
                   .IsUnicode(false)
                   .HasMaxLength(20);

            builder.Property(p => p.EnglishFirstName)
                   .IsUnicode(false)
                   .HasMaxLength(63);

            builder.Property(p => p.IdNumber)
                   .IsUnicode(false)
                   .HasMaxLength(63);
        }
    }
}
