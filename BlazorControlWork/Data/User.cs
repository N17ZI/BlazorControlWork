using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace BlazorControlWork.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        [BsonIgnoreIfNull]
        public string Specialist { get; set; }
        public string pathImg { get; set; }
        [BsonIgnoreIfNull]
        public string INN { get; set; }
        [BsonIgnoreIfNull]
        public string OGRN { get; set; }
        [BsonIgnoreIfNull]
        public string Phone { get; set; }
        [BsonIgnoreIfNull]
        public string Org { get; set; }


        public User(string name, string surname, string email, string password, string login, string specialist,
            string iNN,string oGRN,string phone,string org)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Login = login;
            Specialist = specialist;
            INN = iNN;
            OGRN = oGRN;
            Phone = phone;
            Org = org;
            
        }
    }
}
