using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Categoria
    {
        private String categoria;
        private int id;

        public MO_Categoria() { }

        public MO_Categoria(string categoria, int id)
        {
            this.Categoria = categoria;
            this.Id = id;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public int Id { get => id; set => id = value; }
    }
}
