namespace DAL.Entities
{

    /* Данный класс олицетворяет доп машины. Это может быть цвет, колесо, фары и т.д.
    *  Считается, что данный элемент может быть выбран при заказе автомобиля. Перечень доступных допов зависит от модели выбранного авто.
    */

    internal class Part : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public Part(string name, string description, double cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
}
