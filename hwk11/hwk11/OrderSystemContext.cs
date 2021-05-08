using OrderManageSystem;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hwk11
{
    public partial class OrderSystemContext : DbContext
    {
        public OrderSystemContext()
            : base("name=OrderSystemContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
        public DbSet<Order> DBOrder { get; set; }
        public DbSet<OrderDetail> DBOrderDetail { get; set; }
        public DbSet<Good> DBGood { get; set; }
        public DbSet<Customer> DBCustomer { get; set; }
    }
}
