using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        //Esse arquivo configura as classes para que seja replicado no banco de dados
        //Este método configura sem ser da forma por convenção
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(g=> g.Id);
            builder.Property(g => g.Nome)
                    .IsRequired()
                    .HasMaxLength(400);

            builder.Property(g => g.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(g => g.UrlFoto)
                    .IsRequired()
                    .HasMaxLength(1000);

            //Relacionamento Um para Muitos
            builder.HasMany(g => g.Postagens).WithOne(p => p.Grupo);



        }
    }
}
