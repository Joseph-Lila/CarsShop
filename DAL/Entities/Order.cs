using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /* Данный класс олицетворяет заказ.
    *  ManagerId здесь - указатель на таблицу "Account". Изначально менеджер не привязан к заказу - поэтому тип nullable.
    */

    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Обычные поля

        public double TotalCost { get; set; }
        public DateTime Date { get; set; }

        // --- Внешние ключи и нав. свойства

        [ForeignKey("Title")]
        public string StatusTitle { get; set; } = null!;   // внешний ключ
        public Status Status { get; set; } = null!;   // навигационное свойство

        public int? ManagerId { get; set; }   // внешний ключ
        [ForeignKey("ManagerId")]
        [InverseProperty("ManagerOrders")]
        public Account? Manager { get; set; }   // навигационное свойство

        public int AccountId { get; set; }   // внешний ключ
        [ForeignKey("AccountId")]
        [InverseProperty("Orders")]
        public Account Account { get; set; } = null!;   // навигационное свойство

        // --- Коллекции

        public List<OrderCar> OrderCars { get; set; } = new();
        public List<OrderCarPart> OrderCarParts { get; set; } = new();
        public List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
