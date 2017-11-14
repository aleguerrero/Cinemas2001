using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Usuario
    {
        private String username, nombre, apellidos, contrasena;
        private int dni;
        private DateTime fechaDeNacimiento;

        public string Username { get => username; set => username = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    }
}
