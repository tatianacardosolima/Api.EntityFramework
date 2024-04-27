using API.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.EntityFramework.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        
        public  void  Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client", "dbo");
            
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.ModifiedAt).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd().IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Document).IsRequired(true).HasMaxLength(14).HasColumnType("varchar(14)");
            builder.Property(x => x.DocumentDate);
        }
    }
}
