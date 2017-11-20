using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Sala
    {
        private int id;
        private String id_Sede;

        public MO_Sala() { }

        public MO_Sala(int id, string id_Sede)
        {
            this.Id = id;
            this.Id_Sede = id_Sede;
        }

        public int Id { get => id; set => id = value; }
        public string Id_Sede { get => id_Sede; set => id_Sede = value; }
    }
}
