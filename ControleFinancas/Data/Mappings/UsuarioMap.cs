using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFacil.Api.Data.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario")
            .HasKey(u => u.Id);

        builder.Property(u => u.Email)
            .HasColumnType("VARCHAR")
            .IsRequired();

        builder.Property(u => u.Senha)
            .HasColumnType("VARCHAR")
            .IsRequired();

        builder.Property(u => u.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired();

        builder.Property(u => u.DataInaticacao)
            .HasColumnType("timestamp");
    }
}