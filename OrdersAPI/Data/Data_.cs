using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersAPI;

namespace OrdersAPIContext_OrdersAPI
{
    public class Data_ : DbContext
    {
        public Data_ (DbContextOptions<Data_> options)
            : base(options)
        {
        }

        public DbSet<OrdersAPI.Orders> Orders { get; set; } = default!;
        public DbSet<Product> Products { get; set; }
    }
}
