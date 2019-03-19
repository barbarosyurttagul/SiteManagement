using Barbarosoft.SiteManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CurrentOccupierMap : IEntityTypeConfiguration<CurrentOccupier>
    {
        public void Configure(EntityTypeBuilder<CurrentOccupier> builder)
        {
            builder.ToTable(@"CurrentOccupier", @"dbo");
            builder.HasKey("CurrentOccupierId");

            builder.Property(x => x.CurrentOccupierId).HasColumnName("CurrentOccupierId");
            builder.Property(x => x.IdentityNumber).HasColumnName("IdentityNumber");
            builder.Property(x => x.FirstMidName).HasColumnName("FirstMidName");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(x => x.Landlord).HasColumnName("Landlord");
            builder.Property(x => x.CheckinDate).HasColumnName("CheckinDate");
            builder.Property(x => x.CheckoutDate).HasColumnName("CheckoutDate");
            builder.Property(x => x.Flat.FlatId).HasColumnName("FlatId");
        }
    }
}
