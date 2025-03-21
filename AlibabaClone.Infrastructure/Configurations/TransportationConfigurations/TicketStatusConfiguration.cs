using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.TransportationConfigurations
{
    public class TicketStatusConfiguration : IEntityTypeConfiguration<TicketStatus>
    {
        public void Configure(EntityTypeBuilder<TicketStatus> builder)
        {
            builder.ToTable("TicketStatus");
            builder.HasKey(ts => ts.Id);
            builder.Property(ts => ts.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(ts => ts.Title)
                   .IsRequired()
                   .HasMaxLength(255)
                   .IsUnicode(false);
            builder.HasIndex(ts => ts.Title)
                   .IsUnique();
        }
    }
}
