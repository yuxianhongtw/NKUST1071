using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YX.Core.Models;

namespace YX.Core.Database
{
    public class OpenDataDbContext : DbContext
    {
        public string ConnectionString
        {
            get
            {
                // path = Path.Combine(Directory.GetCurrentDirectory(), @"D:\[高科大]軟體工程\github\1116\OpenDataImport\OpenDataImport\App_Data\Database.mdf");
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\[高科大]軟體工程\github\1116\OpenDataImport\OpenDataImport\App_Data\Database.mdf;Integrated Security=True";
            }
        }

        public DbSet<OpenData> OpenData { get; set; }

        public OpenDataDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
