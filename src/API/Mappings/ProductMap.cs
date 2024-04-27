using API.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<ProductValueObject>
    {
        
        public  void  Configure(EntityTypeBuilder<ProductValueObject> builder)
        {
            builder.ToTable("Product", "dbo");
            
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.ModifiedAt).IsRequired(false);
            builder.Property(x => x.ModifiedBy).IsRequired(false);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd().IsRequired()
                .HasColumnType("int");


            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(20).HasColumnType("varchar(200)");
            builder.Property(x => x.CurrentPrice).IsRequired(true);
        }
    }
}
