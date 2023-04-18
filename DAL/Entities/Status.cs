using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{

    /* Данный класс олицетворяет статус.
    *  Статус определяет состояние заказа.
    */

    public class Status : IEntity
    {
        [Key]
        public string Title { get; set; } = null!;

        // --- Обычные поля

        public string Description { get; set; } = null!;

        // --- Коллекции

        public List<Order> Orders { get; set; } = new();
    }
}
