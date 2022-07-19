using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OrderBoard.Datas;

namespace OrderBoard.DbHelpers.SqlServer.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<ContractData>
    {
        public void Configure(EntityTypeBuilder<ContractData> builder)
        {
            builder.ToTable("contracts");
            builder.HasKey(c => c.ContractId);
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c=>c.StartDate).IsRequired();
            builder.Property(c=>c.EndDate).IsRequired();
            builder.Property(c=>c.Price).IsRequired();
            builder.HasOne(c => c.Client)
                .WithMany(c => c.ContractDatas)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
