using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("TableUser");
            collection.InsertOne(user);
        }
        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("TableUser");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("TableUser");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }

        public static void ReplaceByName(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("TableUser");
            collection.ReplaceOne(x => x.Login == login, user);
        }
        public static void DeleteByName(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("TableUser");
            collection.DeleteOne(x => x.Login == login);
        }
    }
}
