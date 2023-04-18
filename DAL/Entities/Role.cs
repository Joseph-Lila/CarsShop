using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{

    /* Данный класс олицетворяет роль пользователя.
    *  От роли зависят возможности пользователя.
    */

    public class Role : IEntity
    {
        [Key]
        public string Title { get; set; } = null!;

        // --- Обычные поля

        public string Description { get; set; } = null!;

        // --- Коллекции

        public List<Account> Accounts { get; set; } = new();
    }
}
