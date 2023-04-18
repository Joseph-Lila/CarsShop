namespace DAL.Entities
{

    /* Данный класс олицетворяет деталь. Любая деталь, встречающаяся в автомобиле.
    *  Детали имеют свой каталог и продаются как независимые элементы.
    */

    internal class Detail : IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public Detail(string title, string description, double cost)
        {
            Title = title;
            Description = description;
            Cost = cost;
        }
    }
}
