namespace DAL.Entities
{
    internal class OrderCar : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public OrderCar(int id, int orderId, int carId)
        {
            Id = id;
            OrderId = orderId;
            CarId = carId;
        }
    }
}
