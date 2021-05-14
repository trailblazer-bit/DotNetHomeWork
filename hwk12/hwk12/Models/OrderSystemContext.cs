using Microsoft.EntityFrameworkCore;
using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hwk12.Models
{
    public class OrderSystemContext:DbContext
    {
        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {
            this.Database.EnsureCreated();  //自动建库建表
        }
        public DbSet<Order> DBOrder { get; set; }
        public DbSet<OrderDetail> DBOrderDetail { get; set; }
        public DbSet<Good> DBGood { get; set; }
        public DbSet<Customer> DBCustomer { get; set; }
    }
}
