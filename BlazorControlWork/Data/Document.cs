namespace BlazorControlWork.Data
{
    [BsonIgnoreExtraElements]
    public class Document
    {
        public string login_document { get; set; }
        public string Departament_document { get; set; }
        public string FileName { get; set; }
    }
}
