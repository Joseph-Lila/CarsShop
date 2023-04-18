namespace DAL.Entities
{
    internal class OrderDetail : IEntity
    {
        public int Id { get; set; }
        public string DetailTitle { get; set; }
        public int OrderId { get; set; }
        public OrderDetail(int id, string detailTitle, int orderId)
        {
            Id = id;
            DetailTitle = detailTitle;
            OrderId = orderId;
        }
    }
}
