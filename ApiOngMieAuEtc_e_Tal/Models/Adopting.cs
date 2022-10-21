using MongoDB.Bson.Serialization.Attributes;

namespace ApiOngMieAuEtc_e_Tal.Models
{
    public class Adopting
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }



    }
}
