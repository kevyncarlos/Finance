using System;
using System.Collections.Generic;
using System.Text;
using Finance.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finance.Data.Mappings
{
    public class MoneyMap : IEntityTypeConfiguration<Money>
    {
        public void Configure(EntityTypeBuilder<Money> builder)
        {
            builder.ToTable("Moneys");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Observation).HasMaxLength(100);
            builder.Property(x => x.Code).HasMaxLength(3).IsRequired();
        }
    }
}
