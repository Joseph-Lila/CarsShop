using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{

    /* Данный класс олицетворяет доп машины. Это может быть цвет, колесо, фары и т.д.
    *  Считается, что данный элемент может быть выбран при заказе автомобиля. Перечень доступных допов зависит от модели выбранного авто.
    */

    public class Part : IEntity
    {
        [Key]
        public string Name { get; set; } = null!;

        // --- Обычные поля

        public string Description { get; set; } = null!;
        public double Cost { get; set; }

        public string LinkToPicture { get; set; } = null!;

        // --- Коллекции

        public List<CarPart> CarParts { get; set; } = new();
    }
}
