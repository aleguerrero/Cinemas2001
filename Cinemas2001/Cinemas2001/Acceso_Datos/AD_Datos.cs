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
                    sUsuario = contexto.Usuarios.Where(cL => cL.Username == pUsuario.Username).First();
                } catch (Exception e)
                {

                }
            }
            return sUsuario;
        }

        public Boolean fn_registro_usuario(Usuario pUsuario)
        {
            List <string> vComprobacion;
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    if (contexto.Usuarios.Select(u => u.Username == pUsuario.Username).First())
                    {
                        return false;
                    } else
                    {
                        contexto.Usuarios.Add(pUsuario);
                        contexto.SaveChanges();
                        return true;
                    }
                    
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

        public List<String> fn_Consulta_Horarios(string pPelicula, string pSede)
        {
            int vIDPelicula;
            List<String> vHorarios = new List<String>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    vIDPelicula = contexto.Peliculas.Where(p => p.Nombre == pPelicula).Select(p => p.ID).First();
                    string vIDSede = contexto.Sedes.Where(se => se.Nombre == pSede).Select(se => se.ID).First();
                    List<string> vIDSala = contexto.Salas.Where(sa => sa.ID_Sede == vIDSede).Select(sa => sa.ID).ToList();
                    List<int> vIDHorarios = contexto.Horarios.Select(h => h.id).ToList();

                    for (int i = 0; i < vIDSala.Count; i++)
                    {
                        for (int j = 0; j < vIDHorarios.Count; j++)
                        {
                            try
                            {
                                string vIDSa = vIDSala.ElementAt(i);
                                int vIDHorario = vIDHorarios.ElementAt(j);
                                vHorarios.Add(contexto.Horarios.Where(h => h.id == vIDHorario && h.id_pelicula == vIDPelicula && h.id_sala == vIDSa).Select(h => h.fecha_horario.ToString()).First());
                            }
                            catch (Exception e)
                            {

                            }
                        }    
                    }
                    
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
            int vIDFila, vIDHorario = 0, vPelicula;
            String vIDSede;
            List<string> vIDSalas = new List<string>();
            List<int> vIDAsiento = new List<int>();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities()) {
                try
                {
                    contexto.Database.Connection.Open();

                    //JOINS
                    vIDSede = contexto.Sedes.Where(se => se.Nombre == pSede).Select(se => se.ID).First();
                    vIDSalas = contexto.Salas.Where(sa => sa.ID_Sede == vIDSede).Select(sa => sa.ID).ToList();
                    vIDFila = contexto.Fila_Asiento.Where(f => f.Fila_Asiento1 == pFila).Select(f => f.ID_Fila_Asiento).First();
                    vPelicula = contexto.Peliculas.Where(p => p.Nombre == pPelicula).Select(p => p.ID).First();

                    for(int i = 0; i < vIDSalas.Count; i++)
                    {
                        try
                        {
                            string vNum = vIDSalas.ElementAt(i);
                            vIDHorario = contexto.Horarios.Where(h => h.id_sala == vNum && h.fecha_horario == pHorario && h.id_pelicula == vPelicula).Select(h => h.id).First();
                        } catch (Exception e)
                        {

                        }
                    }
                    vIDAsiento = contexto.Asiento_Horario.Where(ah => ah.id_Horario == vIDHorario && ah.Disponibilidad == true).Select(ah => ah.id_Asiento).ToList();

                    //CONSULTA FINAL
                    for (int i = 0; i < vIDAsiento.Count; i++)
                    {
                        try
                        {
                            int vIDA = vIDAsiento.ElementAt(i);
                            lAsientos.Add(contexto.Asientoes.Where(a => a.ID_Fila_Asiento == vIDFila && a.ID_Asiento == vIDA).
                                Select(a => a.Num_Asiento.ToString()).
                                First());
                        } catch (Exception e)
                        {

                        }
                        
                    }

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

                    //lAsientos = contexto.("select a.Num_Asiento, fa.Fila_Asiento " +
                    //    "from asiento a, Fila_Asiento fa, Asiento_Horario ah, Horario h, Pelicula p, Sala sa, Sede s " +
                    //    "where fa.ID_Fila_Asiento = a.ID_Fila_Asiento " +
                    //    "and a.ID = ah.id_Asiento " +
                    //    "and ah.id_Horario = h.id " +
                    //    "and h.id_pelicula = p.ID " +
                    //    "and h.id_sala = sa.ID " +
                    //    "and sa.ID_Sede = s.ID " +
                    //    "and p.Nombre = 'Spiderman 2' " +
                    //    "and h.fecha_horario = '5:00:00' " +
                    //    "and s.Nombre = 'San José' " +
                    //    "and fa.Fila_Asiento = 'A'");

                    return lAsientos;
                } catch (Exception e)
                {
                    return null;
                }
            }
        }

        public Boolean fn_Guardar_Campos(int pAsiento, string pFilaAsiento, string pPelicula, string pSede, TimeSpan pHorario, int vDNI)
        {
            int vIDFilaAsiento;
            List<int> vAsiento;
            int vIDHorario = 0;
            Asiento_Horario vAH = new Asiento_Horario();

            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();

                    //ID Asiento
                    vIDFilaAsiento = contexto.Fila_Asiento.Where(fa => fa.Fila_Asiento1 == pFilaAsiento).Select(fa => fa.ID_Fila_Asiento).First();

                    //Cambia disponibilidad
                    vAsiento = contexto.Asientoes.Where(a => a.ID_Fila_Asiento == vIDFilaAsiento && a.Num_Asiento == pAsiento).Select(a => a.ID_Asiento).ToList();
                    int vPelicula = contexto.Peliculas.Where(p => p.Nombre == pPelicula).Select(p => p.ID).First();
                    string vSede = contexto.Sedes.Where(se => se.Nombre == pSede).Select(se => se.ID).First();
                    List <string> vIDSalas = contexto.Salas.Where(sa => sa.ID_Sede == vSede).Select(sa => sa.ID).ToList();
                    for (int i = 0; i < vIDSalas.Count; i++)
                    {
                        try
                        {
                            string vNum = vIDSalas.ElementAt(i);
                            vIDHorario = contexto.Horarios.Where(h => h.id_sala == vNum && h.fecha_horario == pHorario && h.id_pelicula == vPelicula).Select(h => h.id).First();
                        }
                        catch (Exception e)
                        {

                        }
                    }

                    for (int i = 0; i < vAsiento.Count; i++)
                    {
                        try
                        {
                            int vIDAsiento = vAsiento.ElementAt(i);
                            vAH = contexto.Asiento_Horario.Where(ah => ah.id_Horario == vIDHorario && ah.id_Asiento == vIDAsiento).First();
                        } catch (Exception c)
                        {

                        }
                    }
                    
                    vAH.Disponibilidad = false;
                    contexto.Entry(vAH).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    
                    return fn_Agregar_Ticket(vDNI, vIDHorario, pHorario, pPelicula);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public Boolean fn_Agregar_Ticket(int vIDUsuario, int vIDHorario, TimeSpan vHorario, string vPelicula)
        {
            Ticket iTicket = new Ticket();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    iTicket.id_Horario = vIDHorario;
                    iTicket.id_Usuario = vIDUsuario;
                    iTicket.horario = vHorario;
                    iTicket.nom_pelicula = vPelicula;
                    contexto.Tickets.Add(iTicket);
                    contexto.SaveChanges();
                    return true;

                } catch (Exception e)
                {
                    return false;
                }
            }
        }

        public string fn_Consulta_Sala(string pPelicula, TimeSpan pHorario)
        {
            using (Cinemas2001Entities contexto  = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    int vIDPelicula = contexto.Peliculas.Where(p => p.Nombre == pPelicula).Select(p => p.ID).First();
                    string vIDSala = contexto.Horarios.Where(h => h.id_pelicula == vIDPelicula && h.fecha_horario == pHorario).Select(h => h.id_sala).First();
                    return contexto.Salas.Where(sa => sa.ID == vIDSala).Select(sa => sa.Num_Sala).First();
                } catch (Exception e)
                {
                    return null;
                }
            }
        }

        public List<Ticket> fn_Consulta_Tickets(Ticket pTicket)
        {
            List<Ticket> vTicket;
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    vTicket = contexto.Tickets.Where(t => t.id_Usuario == pTicket.id_Usuario).ToList();
                    return vTicket;
                } catch (Exception e)
                {
                    return null;
                }
            }
        }

        public Pelicula fn_ConsultaPelicula(Pelicula pPelicula)
        {
            Pelicula sPelicula = new Pelicula();
            using (Cinemas2001Entities contexto = new Cinemas2001Entities())
            {
                try
                {
                    contexto.Database.Connection.Open();
                    sPelicula = contexto.Peliculas.Where(c => c.Nombre == pPelicula.Nombre).First();
                }
                catch (Exception e)
                {

                }
            }
            return sPelicula;

        }

        public Boolean fn_ActualizarPelicula(Pelicula pPelicula)
        {

            try
            {
                using (Cinemas2001Entities contexto = new Cinemas2001Entities())
                {
                    contexto.Database.Connection.Open();
                    var PeliculaActualizar = contexto.Peliculas.Where(sPelicula => sPelicula.ID == pPelicula.ID).First();

                    PeliculaActualizar.Nombre = pPelicula.Nombre;
                    PeliculaActualizar.Categoria = pPelicula.Categoria;
                    PeliculaActualizar.Duracion = pPelicula.Duracion;

                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
