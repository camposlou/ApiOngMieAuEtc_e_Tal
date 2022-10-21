using ApiOngMieAuEtc_e_Tal.Models;
using ApiOngMieAuEtc_e_Tal.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ApiOngMieAuEtc_e_Tal.Service
{
    public class AdoptingService
    {
        private readonly IMongoCollection<Adopting> _adopting;

        public AdoptingService(IDataBaseSettings settings)
        {
            var adopting = new MongoClient(settings.ConnectionString);
            var database = adopting.GetDatabase(settings.DataBaseName);
            _adopting = database.GetCollection<Adopting>(settings.AdoptingCollectionName);
        }

        public Adopting Create(Adopting adopting)
        {
            _adopting.InsertOne(adopting);
            return adopting;
        }

        public List<Adopting> Get() =>
            _adopting.Find<Adopting>(adopting => true).ToList();

        public Adopting Get(string id) =>
            _adopting.Find<Adopting>(adopting => adopting.Id == id).FirstOrDefault();

        public void Update(string id, Adopting adoptingIn) =>
            _adopting.ReplaceOne(adopting => adopting.Id == id, adoptingIn);

        public void Remove(string id) =>
           _adopting.DeleteOne(adopting => adopting.Id == id);
    }
}
