namespace DAL.Entities
{

    /* Данный класс олицетворяет доп определенного автомобиля.
    *  Именно этот класс определяет, какие допы могут выбираться для конкретного авто.
    */

    internal class CarPart : IEntity
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public int CarId { get; set; }
        public CarPart(int id, string partName, int carId)
        {
            Id = id;
            PartName = partName;
            CarId = carId;
        }
    }
}
