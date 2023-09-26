using ETrade.Ent;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> op) : base(op)
        {

        }
        // 
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Properties> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => new { od.OrderId, od.FoodId });
            // bu ikisi kompozit key olacak 
        }
    }
}
