using API.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.EntityFramework.Mappings
{
    public class PurchaseOrderMap : IEntityTypeConfiguration<PurchaseOrder>
    {
        
        public  void  Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            builder.ToTable("PurchaseOrder", "dbo");

            builder.Property(x => x.ClientId).IsRequired(true);
            builder.Property(x => x.DateIssue).IsRequired(true);
            builder.Property(x => x.Status).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.ModifiedAt).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd().IsRequired()
                .HasColumnType("int");

            //builder.Property(x => x.PhoneNumber).IsRequired(true).HasMaxLength(20).HasColumnType("varchar(20)");
            //builder.Property(x => x.Email).IsRequired(true).HasMaxLength(45).HasColumnType("varchar(45)");
        }
    }
}
