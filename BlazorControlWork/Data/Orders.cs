using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace BlazorControlWork.Data
{
    public class Orders
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; set; }
        public string Description { get; set; }
        [BsonIgnoreIfNull]
        public string Docs { get; set; }
        [BsonIgnoreIfNull]
        public bool Required { get; set; }
        [BsonIgnoreIfNull]
        public double price { get; set; }
        public string Category { get; set; }


        public Orders(string name, string description, string docs, bool required)
        {
            Name = name;
            Description = description;
            Docs = docs;
            Required = required;
        }
    }
}
