using SDS.back.colecciones;
using SDS.back.entities.messages;
using SDS.back.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SDS.back.colecciones
{
    public class Coleccion_mensajes : CRUD_Collection<Mensaje>
    {
        public Coleccion_mensajes()
        {
            collection = repository.
                DataBase.
                GetCollection<Mensaje>(nameof(Mensaje));
        }

        public List<Mensaje> MensajesPorDestinatario( string llave_publica)
        {
            //return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
            var mensajes = this.GetAllAsync().Result;

            var result = from m in mensajes
                         where m.llave_publica == llave_publica
                         select m;

            return result.ToList();

        }

       

    }
}

