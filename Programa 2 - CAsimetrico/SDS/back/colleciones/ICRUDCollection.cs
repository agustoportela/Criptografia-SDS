
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SDS.back.colecciones
{
    public interface ICRUDCollection<T>
    {
        Task InsertOneAsync(T modelBaseMongo);
        Task InsertManyAsync(List<T> modelsBaseMongo);
        Task DeleteAsync(ObjectId modelBaseMongoId);
        Task UpdateAsync(T modelBaseMongo);
        
        Task<T> GetByIdAsync(ObjectId modelBaseMongoId);
        Task<List<T>> GetAllAsync();

    }
}
