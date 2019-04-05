using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        //Esse arquivo configura as classes para que seja replicado no banco de dados
        //Este método configura sem ser da forma por convenção
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(s=> s.Id);
            builder.Property(u => u.Descricao).HasMaxLength(400).IsRequired();

            builder.HasData
                (
                    new StatusRelacionamento() { Id = 1, Descricao = "Nao Especificado" },
                    new StatusRelacionamento() { Id = 2, Descricao = "Solteiro" },
                    new StatusRelacionamento() { Id = 3, Descricao = "Casado" },
                    new StatusRelacionamento() { Id = 4, Descricao = "Em Relacionamento Sério" }
                );
        }
    }
}
