using Barbarosoft.SiteManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework.Mappings
{
    public class FlatMap : IEntityTypeConfiguration<Flat>
    {
        public void Configure(EntityTypeBuilder<Flat> builder)
        {
            builder.ToTable(@"Flats", @"dbo");
            builder.HasKey("FlatId");

            builder.Property(x => x.BlockName).HasColumnName("BlockName");
            builder.Property(x => x.FlatName).HasColumnName("FlatName");
        }
    }
}
