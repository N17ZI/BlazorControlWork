namespace BlazorControlWork.Data
{
    public class UserService
    {
        public User user { get; set; }

        public static string login;
        public static string INN;
        public static string OGRN;
        public static string Org;
        public static string Phone;
        public static string role;
        public static string email;
        public static string surname;
        public static string name;
        public bool authorizationCheck { get; set; }
    }
}
