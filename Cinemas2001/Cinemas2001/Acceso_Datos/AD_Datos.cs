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
                    sUsuario = contexto.Usuario.Where(cL => cL.Username == pUsuario.Username && cL.Password == pUsuario.Password).First();
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
                    contexto.Usuario.Add(pUsuario);
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

        public Boolean fn_Cambiar_Password(Usuario pUsuario, string pNuevaPass)
        {
            Usuario sUsuario = new Usuario();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sUsuario = contexto.Usuarios.Where(cL => cL.Username == pUsuario.Username && cL.Password == pUsuario.Password).First();
                    sUsuario.Password = pNuevaPass;
                    contexto.Entry(sUsuario).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public List<Tarjeta_Credito> fn_Consultar_Tarjetas(Usuario pUsuario)
        {
            List<Tarjeta_Credito> vTarjetasC = new List<Tarjeta_Credito>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    vTarjetasC = contexto.Tarjeta_Credito.Where(cL => cL.ID_Usuario == pUsuario.DNI).ToList();
                    return vTarjetasC;
                }
                catch (Exception e)
                {
                    return null;   
                }
            }
        }

        public Boolean fn_Agregar_Tarjeta(Tarjeta_Credito pTarjeta)
        {
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    contexto.Tarjeta_Credito.Add(pTarjeta);
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en registro, error: " + e.Message);
                    return false;
                }
            }
        }

        public Boolean fn_Eliminar_Tarjeta(Tarjeta_Credito pTarjeta)
        {
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    pTarjeta = contexto.Tarjeta_Credito.Where(n => n.Numero_Tarjeta == pTarjeta.Numero_Tarjeta).First();
                    contexto.Tarjeta_Credito.Remove(pTarjeta);
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public Boolean fn_Editar_Usuario(Usuario pUsuario, int pDNI)
        {
            Usuario sUsuario = new Usuario();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sUsuario = contexto.Usuarios.Where(cL => cL.DNI == pDNI).First();
                    sUsuario.Nombre = pUsuario.Nombre;
                    sUsuario.Apellidos = pUsuario.Apellidos;
                    sUsuario.DNI = pUsuario.DNI;
                    sUsuario.Username = pUsuario.Username;
                    contexto.Entry(sUsuario).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
