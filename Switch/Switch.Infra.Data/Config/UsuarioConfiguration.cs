using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        //Esse arquivo configura as classes para que seja replicado no banco de dados
        //Este método configura sem ser da forma por convenção
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.SobreNome).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.UrlFoto).HasMaxLength(400).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();

            //Relacionamento Um pra Um
            builder.HasOne(u => u.Identificacao)
                    .WithOne(i => i.Usuario)
                    .HasForeignKey<Identificacao>(i => i.UsuarioId);

            //Relacionamento Um para Muitos
            builder.HasMany(u => u.Postagens)
                    .WithOne(p => p.Usuario);


        }
    }
}
