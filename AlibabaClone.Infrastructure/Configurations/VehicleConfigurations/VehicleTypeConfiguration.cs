using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.VehicleConfigurations
{
    public class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.ToTable("VehicleType");
            builder.HasKey(vt => vt.Id);
            builder.Property(vt => vt.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(vt => vt.Title)
                   .IsRequired()
                   .HasMaxLength(63)
                   .IsUnicode(false);
            builder.HasIndex(vt => vt.Id)
                   .IsUnique();
        }
    }
}
