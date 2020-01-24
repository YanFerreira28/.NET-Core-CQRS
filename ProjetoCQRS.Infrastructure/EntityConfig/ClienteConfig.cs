using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCQRS.Infrastructure.EntityConfig
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.id);
            builder.Property(c => c.nome).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(c => c.sobrenome).IsRequired().HasColumnType("varchar").HasMaxLength(70);
            builder.Property(c => c.email).IsRequired().HasColumnType("varchar").HasMaxLength(125);
        }
    }
}
