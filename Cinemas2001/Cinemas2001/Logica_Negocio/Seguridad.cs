using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Cinemas2001.Logica_Negocio
{
    class Seguridad
    {
        private string clave = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";
        //clave

        public string fn_cifrar(string pCadena)
        {
            byte[] vLlave;//Arreglo donde guardamos la llave para el cifrado 3DES
            byte[] vArreglo = UTF8Encoding.UTF8.GetBytes(pCadena);//Arreglo donde guardaremos la cadena descifrada.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            vLlave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();


            //Ciframos utilizando el Algoritmo 3DES.   
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = vLlave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor();
            byte[] resultado = convertir.TransformFinalBlock(vArreglo, 0, vArreglo.Length);
            tripledes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }

        public string fn_decifrar(string pCadena)
        {
            byte[] vLlave;//Arreglo donde guardamos la llave para el cifrado 3DES
            byte[] vArreglo = Convert.FromBase64String(pCadena);//Arreglo donde guardaremos la cadena descifrada.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            vLlave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.   

            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();

            tripledes.Key = vLlave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;

            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(vArreglo, 0, vArreglo.Length);
            tripledes.Clear();

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
