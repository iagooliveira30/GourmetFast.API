using GourmetFast.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetFast.Repository.EntitiesConfiguration
{
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Endereco).HasMaxLength(200).IsRequired();
        }
    }
}
 