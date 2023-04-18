using DAL.Entities;

namespace DAL.Adapters.Repositories
{
    public interface IRepository
    {
        public bool RegisterClient(string login, string password, string fio, string country, string city);
        public bool RegisterManager(string login, string password, string fio, string country, string city);
        public bool RegisterAdministrator(string login, string password, string fio, string country, string city);
        public List<Car> GetCars();
        public List<Detail> GetDetails();
        public List<CarPart> GetCarParts(int CarId);
        public int CreateOrder(List<Car> cars, List<Detail> details, List<CarPart> carParts);
        public bool LinkOrderWithManager(int orderId, int managerId);
        public bool ChangeOrderStatus(int orderId, string statusTitle);
        public List<Order> GetOrders();
        public List<Order> GetCustomerOrders(int customerId);
    }
}
