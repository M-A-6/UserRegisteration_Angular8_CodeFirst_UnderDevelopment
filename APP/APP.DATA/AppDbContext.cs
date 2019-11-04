using APP.MODEL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace APP.DATA
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public AppDbContext()
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.                
                //optionsBuilder.UseSqlServer("Server=sqlserver2019db.database.windows.net;Initial Catalog=CompanyDb;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer("Server=sqlserver2019db.database.windows.net;Initial Catalog=CompanyDb;Persist Security Info=False;User ID=sqlserveruser;Password=P@ss12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}