using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.back.entities.messages
{
    public class Mensaje : ModelBaseMongo
    {

        public Mensaje(ObjectId creador, string texto, string asunto, string llave_publica)
        {
            this.creador = creador;
            this.texto = texto;
            this.asunto = asunto;
            this.llave_publica = llave_publica;
            _encriptarTexto();

        }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId creador { get; set; }


       
        [BsonRepresentation(BsonType.String)]
        public string texto { get; set; }


        [BsonRepresentation(BsonType.String)]
        public string asunto { get; set; }


        [BsonRepresentation(BsonType.String)]
        public string llave_publica { get; set; }


        private void _encriptarTexto()
        {
            this.texto = Cifrador.encriptar(this.texto, this.llave_publica);
        }

        public void DesencriptarTexto(string llave_privada)
        {
            this.texto = Cifrador.desencriptar(this.texto, llave_privada);
        }

    }



}
