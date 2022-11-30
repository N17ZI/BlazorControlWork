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
        public string Required { get; set; }
        [BsonIgnoreIfNull]
        public double price { get; set; }
        public string Category { get; set; }
        [BsonIgnoreIfNull]

        public string Developer { get; set; }
        public string Creator { get; set; }


        public Orders(string name, string description, string docs, string required,string category,string creator)
        {
            Name = name;
            Description = description;
            Docs = docs;
            Required = required;
            Category = category;
            Creator = creator;
        }
        public Orders(string name, string description, string docs, string required, string category, string creator,string developer)
        {
            Name = name;
            Description = description;
            Docs = docs;
            Required = required;
            Category = category;
            Creator = creator;
            Developer = developer;
        }
    }
}
