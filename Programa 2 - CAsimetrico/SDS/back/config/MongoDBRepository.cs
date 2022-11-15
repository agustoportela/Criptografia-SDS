using MongoDB.Driver;
using SDS.back.colecciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.back.Config
{
    public class MongoDBRepository
    {
        public MongoClient client { get; set; }
        public IMongoDatabase DataBase { get; set; }
        public MongoDBRepository() 
        {
            client = new MongoClient("mongodb://localhost:80");
            DataBase = client.GetDatabase("TP-SDS");           
        }

     //   public readonly Coleccion_mensajes db_mensajes;
    }

}
