using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OrderBoard.Datas;


namespace OrderBoard.DbHelpers.SqlServer.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<ClientData>
    {
        public void Configure(EntityTypeBuilder<ClientData> builder)
        {
            builder.ToTable("clients");
            builder.HasKey(c => c.ClientId);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.PhoneNumber).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Address).IsRequired();
        }
    }
}
