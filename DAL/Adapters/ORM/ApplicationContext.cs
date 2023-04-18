using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Adapters.ORM
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPart> CarParts { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderCar> OrderCars { get; set; }
        public DbSet<OrderCarPart> OrderCarParts { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // логин и пароль - уникальная пара значений, хоть они и не являются первичным ключом
            modelBuilder.Entity<Account>().HasAlternateKey(a => new { a.Login, a.Password });

            // пусть цена всех товаров будет больше, чем 0
            modelBuilder.Entity<Car>()
                .ToTable(t => t.HasCheckConstraint("Cost", "Cost > 0"));
            modelBuilder.Entity<Detail>()
                .ToTable(t => t.HasCheckConstraint("Cost", "Cost > 0"));
            modelBuilder.Entity<Order>()
                .ToTable(t => t.HasCheckConstraint("TotalCost", "TotalCost > 0"));
            modelBuilder.Entity<Part>()
                .ToTable(t => t.HasCheckConstraint("Cost", "Cost > 0"));
        }
    }
}
