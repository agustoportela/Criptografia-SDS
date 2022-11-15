using SDS.back.Config;

using MongoDB.Bson;
using MongoDB.Driver;
using SDS.back.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SDS.back.colecciones
{
    public class CRUD_Collection<T> : ICRUDCollection<T>
    {
        internal MongoDBRepository repository = new MongoDBRepository();
        protected IMongoCollection<T> collection;
        public async Task DeleteAsync(ObjectId modelBaseMongoId)
        {
            var filter = Builders<T>.Filter.Where(d => ((ModelBaseMongo)(object)d).Id == modelBaseMongoId);
            await collection.DeleteOneAsync(filter);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<T> GetByIdAsync(ObjectId modelBaseMongoId)
        {
            var filter = Builders<T>.Filter.Where(d => ((ModelBaseMongo)(object)d).Id == modelBaseMongoId);
            return await collection.FindAsync(filter).Result.FirstAsync();
        }

        public async Task InsertManyAsync(List<T> modelsBaseMongo)
        {
            await collection.InsertManyAsync(modelsBaseMongo);
        }

        public async Task InsertOneAsync(T modelBaseMongo)
        {
            await collection.InsertOneAsync(modelBaseMongo);
        }


        public async Task UpdateAsync(T modelBaseMongo)
        {
            var filter = Builders<T>.Filter.Where(d => ((ModelBaseMongo)(object)d).Id == ((ModelBaseMongo)(object)modelBaseMongo).Id);
            await collection.ReplaceOneAsync(filter, modelBaseMongo); 
        }
    }
}
