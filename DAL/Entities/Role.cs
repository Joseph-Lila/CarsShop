namespace DAL.Entities
{

    /* Данный класс олицетворяет роль пользователя.
    *  От роли зависят возможности пользователя.
    */

    internal class Role : IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Role(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
