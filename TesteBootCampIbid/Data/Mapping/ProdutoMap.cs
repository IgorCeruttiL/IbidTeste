using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteBootCampIbid.Models;

namespace TesteBootCampIbid.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // Tabela
            builder.ToTable("Produto");
            
            // Chave Primaria
            builder.HasKey(x => x.Id);

            // Gerar Id automaticamente sempre de 1 em 1
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Produto")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                ;

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            // Chave estrangeira da categoria
            builder.Property<int>("ProdutoCategoriaId");
            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.ProdutoCategoriaId);
                
                
        }
    }
}
