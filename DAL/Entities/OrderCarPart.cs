namespace DAL.Entities
{
    internal class OrderCarPart : IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarPartId { get; set; } 
    }
}
