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
            } //aa
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

        public List<string> fn_Cargar_Peliculas()
        {
            List<String> iListaPeliculas = new List<string>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    iListaPeliculas = contexto.Peliculas.Select(p => p.Nombre).ToList();
                    return iListaPeliculas;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public List<String> fn_Consulta_Horarios(string pPelicula)
        {
            int vIDPelicula;
            List<String> vHorarios = new List<String>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    vIDPelicula = contexto.Peliculas.Where(p => p.Nombre == pPelicula).Select(p => p.ID).First();
                    vHorarios = contexto.Horarios.Where(h => h.id_pelicula == vIDPelicula).Select(h => h.fecha_horario.ToString()).ToList();
                    return vHorarios;
                } catch (Exception e)
                {
                    return null;
                }
            }
        }

        public List<String> fn_Consulta_Asientos(string pFila, string pSede)
        {
            List<String> lAsientos = new List<string>();
            int vIDFila;
            String vIDSede;
            String vIDSala;
            using (Cinemas2001Entities contexto = new Cinemas2001Entities()) {
                try
                {
                    contexto.Database.Connection.Open();

                    //FUCK JOINS
                    vIDSede = contexto.Sedes.Where(se => se.Nombre == pSede).Select(se => se.ID).First();
                    vIDSala = contexto.Salas.Where(sa => sa.ID_Sede == vIDSede).Select(sa => sa.ID).First();
                    vIDFila = contexto.Fila_Asiento.Where(f => f.Fila_Asiento1 == pFila).Select(f => f.ID_Fila_Asiento).First();

                    //CONSULTA FINAL
                    lAsientos = contexto.Asientoes.Where(f => f.ID_Fila_Asiento == vIDFila && f.ID_Sala == vIDSala && f.Disponibilidad == true).Select(f => f.Num_Asiento.ToString()).ToList();
                    return lAsientos;
                } catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
