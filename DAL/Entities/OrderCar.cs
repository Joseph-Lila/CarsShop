using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /*
     * Машина заказа. Заказы с машинами относятся как многие-ко-многим. Данная таблица "разрывает" это отношение.
     */

    public class OrderCar : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Внешние ключи и нав. свойства

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;

        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; } = null!;
    }
}
