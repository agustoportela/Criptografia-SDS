using SDS.back.colecciones;
using SDS.back.entities.messages;
using SDS.back.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SDS.back.entities;

namespace SDS.back.colecciones
{
    public class Coleccion_usuarios : CRUD_Collection<Users>
    {
        public Coleccion_usuarios()
        {
            collection = repository.DataBase.GetCollection<Users>(nameof(Users));
        }

        public List<Users> Login( string nick , string pass)
        {
            var usuarios = this.GetAllAsync().Result; //sabemos que no es la mejor forma, no se embole

            var result = from u in usuarios
                         where u.nick == nick && u.password == pass
                         select u;

            return result.ToList();

        }

       

    }
}

