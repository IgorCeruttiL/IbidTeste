using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteBootCampIbid.Models;

namespace TesteBootCampIbid.Data.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Tabela
            builder.ToTable("Categoria");

            // Chave Primaria
            builder.HasKey(x => x.Id);

            // Identity, gerar Id automatico de 1 em 1
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Categoria")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);
        }
    }

}
