using Brspontes_RH_System_Domain.CandidateContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Infra.SqlDbContext.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(8);

            builder.Property(p => p.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.District)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.PublicArea)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.State)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(p => p.Street)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
