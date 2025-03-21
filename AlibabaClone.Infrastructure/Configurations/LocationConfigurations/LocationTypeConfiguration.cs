using AlibabaClone.Domain.Aggregates.LocationAggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlibabaClone.Infrastructure.Configurations.LocationConfigurations
{
    public class LocationTypeConfiguration : IEntityTypeConfiguration<LocationType>
    {
        public void Configure(EntityTypeBuilder<LocationType> builder)
        {
            builder.ToTable("LocationType");
            builder.HasKey(lt => lt.Id);
            builder.Property(lt => lt.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(lt => lt.Title)
                   .IsRequired()
                   .HasMaxLength(31);

            builder.HasIndex(LocationType => LocationType.Title)
                   .IsUnique();
        }
    }
}