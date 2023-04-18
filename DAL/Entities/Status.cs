namespace DAL.Entities
{

    /* Данный класс олицетворяет статус.
    *  Статус определяет состояние заказа.
    */

    internal class Status : IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Status(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
