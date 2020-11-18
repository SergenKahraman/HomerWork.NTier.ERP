using HomeWork.NTier.ERP.Data.Entities;
using System.Data.Entity;

namespace HomeWork.NTier.ERP.Data.Context
{
    public class NorthwindDBContext : DbContext //TODO: EF il burada install edildi / AppConfig ayarlandı
    {
        public NorthwindDBContext() : base("CnnStr")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    }
}