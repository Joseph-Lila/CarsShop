using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{

    /* Данный класс олицетворяет автомобиль.
    */

    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Обычные поля

        public double Cost { get; set; }
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string Description { get; set; } = null!;
        public string LinkToPicture { get; set; } = null!;

        // --- Коллекции

        public List<CarPart> CarParts { get; set; } = new();
        public List<OrderCar> OrderCars { get; set; } = new();
    }
}
