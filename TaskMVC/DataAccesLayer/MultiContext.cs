using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace TaskMVC.DataAccesLayer
{
    public class MultiContext : DbContext
    {
        public MultiContext(DbContextOptions options) :base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-IM3K1CPI\\SQLEXPRESS;DataBase=AB106MultiShop;Trusted_Connection=true;TrustServerCertificate = True");
            base.OnConfiguring(options);
        }
    }
}
