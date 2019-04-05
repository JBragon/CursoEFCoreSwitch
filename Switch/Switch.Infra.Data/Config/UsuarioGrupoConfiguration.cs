using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        //Esse arquivo configura as classes para que seja replicado no banco de dados
        //Este método configura sem ser da forma por convenção
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            //Relacionamento Muitos para Muitos
            builder.HasKey(ug=> new { ug.UsuarioId, ug.GrupoId});

            builder.Property(ug => ug.DataCriacao)
                    .IsRequired();

            builder.Property(ug => ug.EhAdministrador);
            
        }
    }
}
