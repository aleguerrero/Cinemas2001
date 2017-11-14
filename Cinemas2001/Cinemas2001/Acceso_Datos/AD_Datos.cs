using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemas2001.Modelo;

namespace Cinemas2001.Acceso_Datos
{
    class AD_Datos
    {
        public Usuario fn_Login(Usuario pUsuario)
        {
            Usuario sUsuario = new Usuario();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sUsuario = contexto.Usuarios.Where(cL => cL.Username == pUsuario.Username && cL.Contraseña == pUsuario.Contraseña).First();
                } catch (Exception e)
                {

                }
            }
            return sUsuario;
        }
    }
}
