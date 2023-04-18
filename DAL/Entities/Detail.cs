using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{

    /* Данный класс олицетворяет деталь. Любая деталь, встречающаяся в автомобиле.
    *  Детали имеют свой каталог и продаются как независимые элементы.
    */

    public class Detail : IEntity
    {
        [Key]
        public string Title { get; set; } = null!;

        // --- Обычные поля

        public string Description { get; set; } = null!;
        public double Cost { get; set; }

        public string LinkToPicture { get; set; } = null!;

        // --- Коллекции

        public List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
