using SDS.back.entities;
using SDS.back.entities.messages;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SDS.back
{
    public static class Cifrador
    {

        public static string[] generarClaves()
        {

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024))
            {

                var llave_publica = rsa.ToXmlString(false);
                var llave_privada = rsa.ToXmlString(true);
                return new string[] { llave_publica , llave_privada };
            }
        }


        public static string encriptar(string texto, string llave_publica)
        {

            using (RSACryptoServiceProvider encriptador_RSA = new RSACryptoServiceProvider(132))
            {

                encriptador_RSA.FromXmlString(llave_publica);

                var texto_a_bytes = Encoding.ASCII.GetBytes(texto);
                byte[] textoDesencriptadoEnBytes = encriptador_RSA.Encrypt(texto_a_bytes,false);

                var bytesDesncriptados_a_texto = Convert.ToBase64String(textoDesencriptadoEnBytes);



                return bytesDesncriptados_a_texto;

            } 
        }



        public static string desencriptar(string texto, string llave_privada)
        {

            using (RSACryptoServiceProvider desencriptador_RSA = new RSACryptoServiceProvider(1024))
            {

                desencriptador_RSA.FromXmlString(llave_privada);

                var texto_a_bytes = Convert.FromBase64String(texto);
                byte[] textoEncriptadoEnBytes = desencriptador_RSA.Decrypt(texto_a_bytes, false);

                var bytesEncriptados_a_texto = Encoding.ASCII.GetString(textoEncriptadoEnBytes);

                return bytesEncriptados_a_texto;

            }
        }
    }
}





// nasheeii