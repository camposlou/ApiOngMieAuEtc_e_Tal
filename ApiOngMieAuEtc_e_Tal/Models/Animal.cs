using MongoDB.Bson.Serialization.Attributes;

namespace ApiOngMieAuEtc_e_Tal.Models
{
    public class Animal
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }

    }
}
