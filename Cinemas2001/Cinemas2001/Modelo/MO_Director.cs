using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Director
    {
        private int id;
        private String nombre, apellidos;

        public MO_Director() { }

        public MO_Director(int id, string nombre, string apellidos)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
