using Microsoft.EntityFrameworkCore;

namespace Fullstack.Model
{
    public class EFDBhandle:DbContext
    {

        public string conn = "Server=DESKTOP-2VNS0L4\\SQLEXPRESS;Database=Customer_Tbl;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }
        public DbSet<Customer> Customers { get; set; }

       
    }
}

