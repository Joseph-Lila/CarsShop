namespace DAL.Entities
{

    /* Данный класс олицетворяет заказ.
    *  ManagerId здесь - указатель на таблицу "Account". Изначально менеджер не привязан к заказу - поэтому тип nullable.
    */

    internal class Order : IEntity
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public double TotalCost { get; set; }
        public DateOnly Date { get; set; }
        public int StatusId { get; set; }
        public int? ManagerId { get; set; }
        public Order(int id, int accountId, double totalCost, DateOnly date, int statusId, int? managerId)
        {
            Id = id;
            AccountId = accountId;
            TotalCost = totalCost;
            Date = date;
            StatusId = statusId;
            ManagerId = managerId;
        }
    }
}
