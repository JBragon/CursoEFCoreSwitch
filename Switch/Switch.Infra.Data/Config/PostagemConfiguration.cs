using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        //Esse arquivo configura as classes para que seja replicado no banco de dados
        //Este método configura sem ser da forma por convenção
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataPublicacao)
                    .IsRequired();
            builder.Property(p => p.Texto)
                    .IsRequired()
                    .HasMaxLength(400);

            //Relacionamento Um para Muitos invertido
            //builder.HasOne(p => p.Usuario)
            //    .WithMany(u => u.Postagens);

        }
    }
}
