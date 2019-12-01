using Brspontes_RH_System_Domain.CandidateContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes_RH_System_Infra.SqlDbContext.Mappings
{
    public class CandidateMapping : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Curriculum)
                .IsRequired();

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Observation)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Active)
                .IsRequired();

            builder.HasOne(c => c.Address)
                .WithOne(a => a.Candidate);
        }
    }
}
