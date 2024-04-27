using API.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.EntityFramework.Mappings
{
    public class PurchaseOrderItemMap : IEntityTypeConfiguration<PurchaseOrderItem>
    {
        
        public  void  Configure(EntityTypeBuilder<PurchaseOrderItem> builder)
        {
            builder.ToTable("PurchaseOrderItem", "dbo");
            builder.Property(x => x.ProductId).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.Amount).IsRequired(true);
            builder.Property(x => x.Tax).IsRequired(true);
            builder.Property(x => x.Discount).IsRequired(true);            
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
