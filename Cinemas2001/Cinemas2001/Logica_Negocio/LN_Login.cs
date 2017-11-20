using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemas2001.Acceso_Datos;
using Cinemas2001.Modelo;

namespace Cinemas2001.Logica_Negocio
{
    class LN_Login
    {
        AD_Datos iAccesoDatos = new AD_Datos();

        public MO_Usuario fn_LoginUsuario(MO_Usuario pUsuario)
        {
            Usuario iUsuario = new Usuario();
            iUsuario.Username = pUsuario.Username;
            iUsuario.Contraseña = pUsuario.Contrasena;

            iUsuario = iAccesoDatos.fn_Login(iUsuario);
            MO_Usuario sUsuario = new MO_Usuario();
            sUsuario.Nombre = iUsuario.Nombre;
            sUsuario.Apellidos = iUsuario.Apellidos;
            return sUsuario;
        }

        public Boolean fn_Registro_Usuario(MO_Usuario pUsuario)
        {
            Usuario iUsuario = new Usuario();
            iUsuario.Username = pUsuario.Username;
            iUsuario.Nombre = pUsuario.Nombre;
            iUsuario.Apellidos = pUsuario.Apellidos;
            iUsuario.DNI = pUsuario.Dni;
            iUsuario.Fecha_de_Nacimiento = pUsuario.FechaDeNacimiento;
            iUsuario.Contraseña = pUsuario.Contrasena;

            return iAccesoDatos.fn_registro_usuario(iUsuario);
        }
        
    }
}
