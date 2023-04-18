using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /*
     * При выборе машины можно указать ее цвет, выбрать колеса и т.п.
     * Машин в одном заказе может быть несколько и, соответственно, допов тоже.
     * Данная таблица "разрывает" отношение многие-ко-многим между таблицами "Order" и "CarPart"
     */

    public class OrderCarPart : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Внешние ключи и нав. свойства

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;

        public int CarPartId { get; set; }
        [ForeignKey("CarPartId")]
        public CarPart CarPart { get; set; } = null!;
    }
}
