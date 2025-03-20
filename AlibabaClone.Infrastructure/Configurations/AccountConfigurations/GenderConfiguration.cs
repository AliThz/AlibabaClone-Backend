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
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Gender");
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(g => g.Title)
                   .IsRequired()
                   .HasMaxLength(63);

            builder.HasIndex(g => g.Title)
                   .IsUnique();
        }
    }
}
