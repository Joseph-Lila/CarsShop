using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /* Данный класс олицетворяет доп определенного автомобиля.
    *  Именно этот класс определяет, какие допы могут выбираться для конкретного авто.
    */

    public class CarPart : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Внешние ключи и нав. свойства

        public string PartName { get; set; } = null!;   //внешний ключ
        [ForeignKey("PartName")]
        public Part Part { get; set; } = null!;   // навигационное свойство

        public int CarId { get; set; }   //внешний ключ
        [ForeignKey("CarId")]
        public Car Car { get; set; } = null!;   // навигационное свойство

        // --- Коллекции

        public List<OrderCarPart> OrderCarParts { get; set; } = new();
    }
}
