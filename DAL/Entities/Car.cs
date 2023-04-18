namespace DAL.Entities
{

    /* Данный класс олицетворяет автомобиль.
    */

    internal class Car : IEntity
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string LinkToPicture { get; set; }

        public Car(int id, double cost, string model, int year, string description, string linkToPicture)
        {
            Id = id;
            Cost = cost;
            Model = model;
            Year = year;
            Description = description;
            LinkToPicture = linkToPicture;
        }
    }
}
