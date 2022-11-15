using SDS.back.colecciones;
using SDS.back.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDS
{
    static class Script_init
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    var colecionMensajes = new Coleccion_mensajes();
        //    var colecionUsuarios = new Coleccion_usuarios();
        //    var usuarios = new List<User>();

        //    var nicks = new string[] { "juancho", "jose", "pepe", "jerundlio", "papaleta", "elverr", "jorgito" , "manuelita" };
        //    var passwords = new string[] { "1234", "4567", "contraseña", "jejeje", "mamo", "uwu", "3245" , "lplp" };

        //    var rand = new Random();


        //    for (int i = 0; i < 20; i++)
        //    {
        //        var user = new User(nicks.ElementAt(rand.Next(0, nicks.Length)), passwords.ElementAt(rand.Next(0, passwords.Length)));
        //        usuarios.Add(user);
        //    }



        //    colecionUsuarios.InsertManyAsync(usuarios.Distinct() as List<User>).Wait();

        //}


        //var colecionMensajes = new Coleccion_mensajes();
        //var colecionUsuarios = new Coleccion_usuarios();


        ////var usuarios = new List<Users>();

        ////var nicks = new string[] { "juancho", "jose", "pepe", "jerundlio", "papaleta", "elverr", "jorgito", "manuelita" };
        ////var passwords = new string[] { "1234", "4567", "contraseña", "jejeje", "mamo", "uwu", "3245", "lplp" };

        ////var rand = new Random();


        ////for (int i = 0; i < 20; i++)
        ////{
        ////    var user = new Users(nicks.ElementAt(rand.Next(0, nicks.Length)), passwords.ElementAt(rand.Next(0, passwords.Length)));
        ////    usuarios.Add(user);
        ////}



        ////colecionUsuarios.InsertManyAsync(usuarios).Wait();


        //var user = colecionUsuarios.Login("pepe", "uwu").First();
        //var mensaje = new Mensaje(user.Id, "hola", "test 1", "<RSAKeyValue><Modulus>x/7hiluVhiiFBJxKpx1y28DSEPeelseYboBPNM6LYSOnXvwI1PEMCb6T7gFJnnX6NLIOC2IuxkhHnjizns2PqvIKsu7sEKx1ftNlcAvC9LlN3cbu1dhTcVWpJjkNpVxYXCEPNTX1Clhqm4Q+5RxGOPVu4740ByhdvUc72VxVsU0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");

        //colecionMensajes.InsertOneAsync(mensaje).Wait();

    }
}
