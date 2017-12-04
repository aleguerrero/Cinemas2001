﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemas2001.Acceso_Datos;
using Cinemas2001.Modelo;

namespace Cinemas2001.Logica_Negocio
{
    class LN_Cinemas2001
    {
        AD_Datos iAccesoDatos = new AD_Datos();
        private static String vUsername, vPassword;
        private static int vDni;
        private static List<int> lTarjetas;
        private static List<String> lPeliculas;

        public static string VUsername { get => vUsername; set => vUsername = value; }
        public static string VPassword { get => vPassword; set => vPassword = value; }
        public static int VDni { get => vDni; set => vDni = value; }
        public static List<int> LTarjetas { get => lTarjetas; set => lTarjetas = value; }
        public static List<string> LPeliculas { get => lPeliculas; set => lPeliculas = value; }

        public MO_Usuario fn_LoginUsuario(MO_Usuario pUsuario)
        {
            Usuario iUsuario = new Usuario();
            iUsuario.Username = pUsuario.Username;
            VUsername = pUsuario.Username;
            iUsuario.Password = pUsuario.Contrasena;
            VPassword = pUsuario.Contrasena;

            iUsuario = iAccesoDatos.fn_Login(iUsuario);
            MO_Usuario sUsuario = new MO_Usuario();
            sUsuario.Nombre = iUsuario.Nombre;
            sUsuario.Apellidos = iUsuario.Apellidos;
            VDni = iUsuario.DNI;
            return sUsuario;
        }

        public Boolean fn_Registro_Usuario(MO_Usuario pUsuario)
        {
            Usuario iUsuario = new Usuario();
            iUsuario.Username = pUsuario.Username;
            iUsuario.Nombre = pUsuario.Nombre;
            iUsuario.Apellidos = pUsuario.Apellidos;
            iUsuario.DNI = pUsuario.Dni;
            iUsuario.Fecha_Nacimiento = pUsuario.FechaDeNacimiento;
            iUsuario.Password = pUsuario.Contrasena;

            return iAccesoDatos.fn_registro_usuario(iUsuario);
        }

        public MO_Usuario fn_Usuario_En_Sesión()
        {
            Usuario iUsuario = new Usuario();
            iUsuario.Username = VUsername;
            iUsuario.Password = VPassword;
            iUsuario = iAccesoDatos.fn_Usuario_Sesion(iUsuario);

            MO_Usuario sUsuario = new MO_Usuario();
            sUsuario.Nombre = iUsuario.Nombre;
            sUsuario.Apellidos = iUsuario.Apellidos;
            sUsuario.Dni = iUsuario.DNI;
            sUsuario.Username = iUsuario.Username;

            return sUsuario;
        }

        public Boolean fn_Cambiar_Password(string pPassAnt, string pPassNueva)
        {
            if (pPassAnt == VPassword)
            {
                Usuario iUsuario = new Usuario();
                iUsuario.Password = VPassword;
                iUsuario.Username = VUsername;
                VPassword = pPassNueva;
                return iAccesoDatos.fn_Cambiar_Password(iUsuario, pPassNueva);
            } else
            {
                return false;
            }
        }

        public List<Tarjeta_Credito> fn_Consultar_Tarjetas()
        {
            Usuario iUsuario = new Usuario();
            List<Tarjeta_Credito> vTarjetasC;
            iUsuario.DNI = VDni;
            vTarjetasC = iAccesoDatos.fn_Consultar_Tarjetas(iUsuario);
            LTarjetas = vTarjetasC.Select(n => n.Numero_Tarjeta).ToList();
            return vTarjetasC;
        }

        public Boolean fn_Registro_Tarjeta(MO_Tarjeta_Credito pTarjeta)
        {
            Tarjeta_Credito iTarjeta = new Tarjeta_Credito();
            iTarjeta.Numero_Tarjeta = pTarjeta.Numero_Tarjeta;
            iTarjeta.CVO = pTarjeta.Cvo;
            iTarjeta.ID_Usuario = VDni;
            return iAccesoDatos.fn_Agregar_Tarjeta(iTarjeta);
        }

        public Boolean fn_Eliminar_Tarjeta(MO_Tarjeta_Credito pTarjeta)
        {
            Tarjeta_Credito iTarjeta = new Tarjeta_Credito();
            iTarjeta.Numero_Tarjeta = pTarjeta.Numero_Tarjeta;
            LTarjetas.Remove(pTarjeta.Numero_Tarjeta);
            return iAccesoDatos.fn_Eliminar_Tarjeta(iTarjeta);
        }

        public Boolean fn_Editar_Usuario(MO_Usuario pUsuario)
        {
            try
            {
                Usuario iUsuario = new Usuario();
                iUsuario.Nombre = pUsuario.Nombre;
                iUsuario.Apellidos = pUsuario.Apellidos;
                iUsuario.DNI = pUsuario.Dni;
                VUsername = pUsuario.Username;
                iUsuario.Username = pUsuario.Username;
                return iAccesoDatos.fn_Editar_Usuario(iUsuario, VDni);
            } catch (Exception e)
            {
                return false;
            }
                
        }

        public List<string> fn_Cargar_Peliculas()
        {
            List<string> iPeliculas = new List<string>();
            try
            {
                iPeliculas = iAccesoDatos.fn_Cargar_Peliculas();
                return iPeliculas;
            } catch (Exception e)
            {
                return null;
            }
        }

        public List<string> fn_Cargar_Horarios(string pPelicula)
        {
            List<string> iHorarios = new List<string>();
            try
            {
                iHorarios = iAccesoDatos.fn_Consulta_Horarios(pPelicula);
                return iHorarios;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<string> fn_Cargar_Asientos(string pFila, string pSede)
        {
            List<string> iAsientos = new List<string>();
            try
            {
                iAsientos = iAccesoDatos.fn_Consulta_Asientos(pFila, pSede);
                return iAsientos;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}