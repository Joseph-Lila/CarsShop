using DAL.Adapters.ORM;
using DAL.Entities;
using DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace DAL.Adapters.Repositories
{
    public class MSSqlRepository : IRepository
    {
        ApplicationContext _context;

        public MSSqlRepository(ApplicationContext context) 
        {
            _context = context;
        }

        public bool ChangeOrderStatus(int orderId, string statusTitle)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                Order order = (Order)_context.Orders.Where(o => o.Id == orderId);
                order.StatusTitle = statusTitle;

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public int CreateOrder(int customerId, List<Car> cars, List<Detail> details, List<Part> parts)
        {
            using var transaction = _context.Database.BeginTransaction();

            // let's count total cost for new order
            double totalCost = 0;
            
            foreach (var car in cars)
            {
                totalCost += car.Cost;
            }
            foreach (var detail in details)
            {
                totalCost += detail.Cost;
            }
            foreach (var part in parts)
            {
                totalCost += part.Cost;
            }

            try
            {
                Order order = new Order() 
                { 
                    TotalCost = totalCost,
                    Date=DateTime.Now,
                    StatusTitle = StatusEnum.Paid.ToString(),
                    ManagerId = null,
                    AccountId = customerId,
                };
                _context.Orders.Add(order);

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();

                return order.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<CarPart> GetCarParts(int carId)
        {
            try
            {
                return _context.CarParts.Where(o => o.CarId == carId).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return new List<CarPart>();
            }
        }

        public List<Car> GetCars()
        {
            try
            {
                return _context.Cars.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return new List<Car>();
            }
        }

        public List<Order> GetCustomerOrders(int customerId)
        {
            try
            {
                return _context.Orders.Where(o => o.AccountId == customerId).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return new List<Order>();
            }
        }

        public List<Detail> GetDetails()
        {
            try
            {
                return _context.Details.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return new List<Detail>();
            }
        }

        public List<Order> GetOrders()
        {
            try
            {
                return _context.Orders
                    .Include(o => o.OrderCars)
                    .Include(o => o.OrderCarParts)
                    .Include(o => o.OrderDetails)
                    .Include(o => o.Account)
                    .Include(o => o.Manager)
                    .AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return new List<Order>();
            }
        }

        public bool LinkOrderWithManager(int orderId, int managerId)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                Order order = (Order)_context.Orders.Where(o => o.Id == orderId);
                order.ManagerId = managerId;

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegisterAdministrator(string login, string password, string fio, string country, string city)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                Account account = new Account()
                {
                    Login = login,
                    Password = password,
                    FIO = fio,
                    Country = country,
                    City = city,
                    RoleTitle = RoleEnum.Administrator.ToString(),
                };

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegisterClient(string login, string password, string fio, string country, string city)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                Account account = new Account()
                {
                    Login = login,
                    Password = password,
                    FIO = fio,
                    Country = country,
                    City = city,
                    RoleTitle = RoleEnum.Customer.ToString(),
                };

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegisterManager(string login, string password, string fio, string country, string city)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                Account account = new Account()
                {
                    Login = login,
                    Password = password,
                    FIO = fio,
                    Country = country,
                    City = city,
                    RoleTitle = RoleEnum.Manager.ToString(),
                };

                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
