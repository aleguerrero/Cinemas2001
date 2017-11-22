using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemas2001.Modelo;
using System.Windows.Forms;

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
                    sUsuario = contexto.Usuarios.Where(cL => cL.Username == pUsuario.Username && cL.Password == pUsuario.Password).First();
                } catch (Exception e)
                {

                }
            }
            return sUsuario;
        }

        public Boolean fn_registro_usuario(Usuario pUsuario)
        {
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    contexto.Usuarios.Add(pUsuario);
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en registro, error: " + e.Message) ;
                    return false;
                }
            }
        }

        public Usuario fn_Usuario_Sesion(Usuario pUsuario)
        {
            Usuario sUsuario = new Usuario();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sUsuario = contexto.Usuarios.Where(cL => cL.Username == pUsuario.Username && cL.Password == pUsuario.Password).First();
                }
                catch (Exception e)
                {

                }
            }
            return sUsuario;
        }
    }
}
