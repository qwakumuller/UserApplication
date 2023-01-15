namespace HelloApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


public class Hello
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public int Id{get; set;}
    
    public string greeting{get; set;}

}