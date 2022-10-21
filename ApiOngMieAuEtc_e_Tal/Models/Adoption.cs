using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ApiOngMieAuEtc_e_Tal.Models
{
    public class Adoption
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string AdoptingId { get; set; }
        public string AnimalId { get; set; }
        public string DataAdocao { get; set; }
    }
}
