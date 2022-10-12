using Corretora.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corretora.Repository.Mapping
{
    public class CotacaoMapping : IEntityTypeConfiguration<Cotacao>
    {
        public void Configure(EntityTypeBuilder<Cotacao> builder)
        {
            builder.ToTable("Cotacao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Acao)
                   .WithMany(x => x.Cotacoes)
                   .HasForeignKey(x => x.AcaoId);

        }
    }
}
