using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderBoard.Datas;
using OrderBoard.DbHelpers.SqlServer.Configurations;

namespace OrderBoard.DbHelpers.SqlServer
{
    public class SqlServerHelper : DbContext
    {
        public SqlServerHelper()
        {
            Database.EnsureCreated();
        }

        public DbSet<OrderData> OrderDatas { get; set; } = null!;
        public DbSet<ClientData> ClientDatas { get; set; } = null!;
        public DbSet<ContractData> ContractDatas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=orderboarddb;Trusted_Connection=True;");
            optionsBuilder.LogTo((obj)=>System.Diagnostics.Debug.WriteLine(obj));
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
        
    }
}
