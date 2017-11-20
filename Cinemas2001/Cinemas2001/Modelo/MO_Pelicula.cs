using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Pelicula
    {
        private int id_Categoria,id_Director, id_Estudio;
        private String id, nombre, descripcion;
        private DateTime duracion;

        public MO_Pelicula() { }

        public MO_Pelicula(int id_Categoria, int id_Director, int id_Estudio, string id, string nombre, string descripcion, DateTime duracion)
        {
            this.Id_Categoria = id_Categoria;
            this.Id_Director = id_Director;
            this.Id_Estudio = id_Estudio;
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
        }

        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
        public int Id_Director { get => id_Director; set => id_Director = value; }
        public int Id_Estudio { get => id_Estudio; set => id_Estudio = value; }
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Duracion { get => duracion; set => duracion = value; }
    }
}
