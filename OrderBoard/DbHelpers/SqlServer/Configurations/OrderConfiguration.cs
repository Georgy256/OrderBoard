using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OrderBoard.Datas;

namespace OrderBoard.DbHelpers.SqlServer.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderData>
    {
        public void Configure(EntityTypeBuilder<OrderData> builder)
        {
            builder.ToTable("orders");
            builder.HasKey(x => x.OrderId);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.ClientId).IsRequired();
            builder.Property(o => o.ContractId).IsRequired();
            builder.Property(o => o.EndDate).IsRequired();
            builder.HasOne(o => o.ClientData)
                .WithMany(c => c.OrderDatas)
                .HasForeignKey(o => o.ClientId);
            builder.HasOne(o => o.ContractData).
                WithMany(c => c.OrderDatas).
                HasForeignKey(o => o.ContractId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
