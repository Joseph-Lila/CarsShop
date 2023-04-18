using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{

    /* Данный класс олицетворяет аккаунт пользователя.
    *  Здесь содержатся все необходимые данные для входа и определения роли пользователя.
    *  Также используя поля "Страна" и "Город" можно получить географическую статистику продаж и выявить наиболее выгодные и провальные пункты.
    */

    public class Account : IEntity
    {
        [Key]
        public int Id { get; set; }

        // --- Обычные поля

        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FIO { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;

        // --- Внешние ключи и нав. свойства

        public string RoleTitle { get; set; } = null!;   // внешний ключ
        [ForeignKey("RoleTitle")]
        public Role Role { get; set; } = null!;   // навигационное свойство

        // --- Коллекции

        public List<Order> ManagerOrders { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
    }
}
