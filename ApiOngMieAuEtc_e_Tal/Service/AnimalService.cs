using ApiOngMieAuEtc_e_Tal.Models;
using ApiOngMieAuEtc_e_Tal.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ApiOngMieAuEtc_e_Tal.Service
{
    public class AnimalService
    {
        private readonly IMongoCollection<Animal> _animal;

        public AnimalService(IDataBaseSettings settings)
        {
            var animal = new MongoClient(settings.ConnectionString);
            var database = animal.GetDatabase(settings.DataBaseName);
            _animal = database.GetCollection<Animal>(settings.AnimalCollectionName);
        }

        public Animal Create(Animal animal)
        {
            _animal.InsertOne(animal);
            return animal;
        }

        public List<Animal> Get() =>
            _animal.Find<Animal>(animal => true).ToList();

        public Animal Get(string id) =>
            _animal.Find<Animal>(animal => animal.Id == id).FirstOrDefault();

        public void Update(string id, Animal animalIn) =>
            _animal.ReplaceOne(animal => animal.Id == id, animalIn);

        public void Remove(string id) =>
           _animal.DeleteOne(animal => animal.Id == id);
    }
}
