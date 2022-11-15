using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.back.entities
{
    public class Users : ModelBaseMongo
    {
        [BsonRepresentation(BsonType.String)]
        public string nick { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string password { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string llave_publica { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string llave_privada { get; set; }

        public Users(string nick, string password)
        {
            this.nick = nick;
            this.password = password;
            
            var claves = Cifrador.generarClaves();

            this.llave_publica = claves[0];
            this.llave_privada = claves[1];
        }

        public Users(string nick, string password, string llave_publica, string llave_privada, ObjectId id) : this(nick, password)
        {
            this.llave_publica = llave_publica;
            this.llave_privada = llave_privada;
            this.Id = id;
        }
    }



}
