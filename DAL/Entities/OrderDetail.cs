using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /*
     * Данная таблица "разрывает" отношение многие-ко-многим между таблицами "Detail" и "Order".
     */

    public class OrderDetail : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Внешние ключи и нав. свойства

        public string DetailTitle { get; set; } = null!;
        [ForeignKey("DetailTitle")]
        public Detail Detail { get; set; } = null!;

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;
    }
}
