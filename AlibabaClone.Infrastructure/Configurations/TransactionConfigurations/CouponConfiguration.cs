using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlibabaClone.Domain.Aggregates.TransactionAggregates;

namespace AlibabaClone.Infrastructure.Configurations.TransactionConfigurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("Coupon");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Code)
                   .IsRequired();

            builder.Property(c => c.Percentage)
                   .IsRequired();

            builder.Property(c => c.MaxDiscount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(c => c.MinBaseAmount)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(c => c.Descrption)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);


            builder.HasOne(c => c.Account)
                   .WithMany()
                   .HasForeignKey(c => c.AccountId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
