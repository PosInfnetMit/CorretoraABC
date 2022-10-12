using Corretora.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Corretora.Repository.Mapping
{
    public class AcaoMapping : IEntityTypeConfiguration<Acao>
    {
        public void Configure(EntityTypeBuilder<Acao> builder)
        {
            builder.ToTable("Acao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Sigla).HasColumnType("varchar").HasMaxLength(10);
        }
    }
}
