namespace DAL.Entities
{

    /* Данный класс олицетворяет аккаунт пользователя.
    *  Здесь содержатся все необходимые данные для входа и определения роли пользователя.
    *  Также используя поля "Страна" и "Город" можно получить географическую статистику продаж и выявить наиболее выгодные и провальные пункты.
    */

    internal class Account : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RoleTitle { get; set; }
        public string FIO { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Account(int id, string login, string password, string roleTitle, string fIO, string country, string city)
        {
            Id = id;
            Login = login;
            Password = password;
            RoleTitle = roleTitle;
            FIO = fIO;
            Country = country;
            City = city;
        }
    }
}
