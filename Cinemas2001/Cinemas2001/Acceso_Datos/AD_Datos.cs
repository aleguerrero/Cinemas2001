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

        public List<String> fn_Consulta_Asientos(string pFila, string pSede, TimeSpan pHorario, string pPelicula)
        {
            List<String> lAsientos = new List<String>();
            int vIDFila, vIDHorario;
            String vIDSede, vIDSala;
            List<int> vIDAsiento = new List<int>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities()) {
                try
                {
                    contexto.Database.Connection.Open();

                    ////JOINS
                    //vIDSede = contexto.Sedes.Where(se => se.Nombre == pSede).Select(se => se.ID).First();
                    //vIDSala = contexto.Salas.Where(sa => sa.ID_Sede == vIDSede).Select(sa => sa.ID).First();
                    //vIDFila = contexto.Fila_Asiento.Where(f => f.Fila_Asiento1 == pFila).Select(f => f.ID_Fila_Asiento).First();
                    //vIDHorario = contexto.Horarios.Where(h => h.id_sala == vIDSala && h.fecha_horario == pHorario).Select(h => h.id).First();
                    //vIDAsiento = contexto.Asiento_Horario.Where(ah => ah.id_Horario == vIDHorario && ah.Disponibilidad == true).Select(ah => ah.id_Asiento).ToList();

                    ////CONSULTA FINAL
                    //for (int i = 0; i < vIDAsiento.Count; i++)
                    //{
                    //    int vIDA = vIDAsiento.ElementAt(i);
                    //    lAsientos.Add(contexto.Asientoes.Where(a => a.ID_Fila_Asiento == vIDFila && a.ID == vIDA).
                    //        Select(a => a.Num_Asiento.ToString()).
                    //        First());
                    //}

                    //var vLista = (from fa in contexto.Fila_Asiento join a in contexto.Asientoes on fa.ID_Fila_Asiento equals a.ID_Fila_Asiento
                    //              join ah in contexto.Asiento_Horario on a.ID equals ah.id_Asiento
                    //              join hr in contexto.Horarios on ah.id_Asiento_Horario equals hr.id
                    //              join p in contexto.Peliculas on hr.id_pelicula equals p.ID
                    //              join sa in contexto.Salas on hr.id_sala equals sa.ID
                    //              join se in contexto.Sedes on sa.ID_Sede equals se.ID
                    //              where fa.Fila_Asiento1 == pFila
                    //              && se.Nombre == pSede
                    //              && hr.fecha_horario == pHorario
                    //              && p.Nombre == pPelicula
                    //              select new {
                    //                  lAsientos = a.Num_Asiento.ToString()
                    //              }).Take(10);

                    lAsientos = contexto.("select a.Num_Asiento, fa.Fila_Asiento " +
                        "from asiento a, Fila_Asiento fa, Asiento_Horario ah, Horario h, Pelicula p, Sala sa, Sede s " +
                        "where fa.ID_Fila_Asiento = a.ID_Fila_Asiento " +
                        "and a.ID = ah.id_Asiento " +
                        "and ah.id_Horario = h.id " +
                        "and h.id_pelicula = p.ID " +
                        "and h.id_sala = sa.ID " +
                        "and sa.ID_Sede = s.ID " +
                        "and p.Nombre = 'Spiderman 2' " +
                        "and h.fecha_horario = '5:00:00' " +
                        "and s.Nombre = 'San José' " +
                        "and fa.Fila_Asiento = 'A'");

                    return lAsientos;
                } catch (Exception e)
                {
                    return null;
                }
            }
        }

    //    public Boolean fn_Guardar_Campos(int pAsiento, string pFilaAsiento)
    //    {
    //        int vIDFilaAsiento;
    //        Asiento vAsiento = new Asiento();

    //        using (Cinemas2001Entities contexto = new Cinemas2001Entities())
    //        {
    //            try
    //            {
    //                contexto.Database.Connection.Open();

    //                //ID Asiento
    //                vIDFilaAsiento = contexto.Fila_Asiento.Where(fa => fa.Fila_Asiento1 == pFilaAsiento).Select(fa => fa.ID_Fila_Asiento).First();

    //                //Cambia disponibilidad
    //                vAsiento = contexto.Asientoes.Where(a => a.ID_Fila_Asiento == vIDFilaAsiento && a.Num_Asiento == pAsiento).First();
    //                vAsiento.Disponibilidad = false;
    //                contexto.Entry(vAsiento).State = System.Data.Entity.EntityState.Modified;
    //                contexto.SaveChanges();
    //                return true;
    //            } catch (Exception e)
    //            {
    //                return false;
    //            }
    //        }
    //    }

    //    public Boolean fn_Agregar_Ticket(Ticket  )
    }
}
