using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJune26.ConsoleApp5
{
    public class ConsoleAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
                {
                    DataSource = "DESKTOP-MN2FBFP\\MSSQLSERVER2022",
                    InitialCatalog = "CSharpJune26",
                    UserID = "sa",
                    Password = "love",
                    TrustServerCertificate = true
                };
                optionsBuilder.UseSqlServer(sb.ConnectionString);
    }
        }
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
