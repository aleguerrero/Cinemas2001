using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Ticket
    {
        private int id, id_usuario, id_cartelera;
        private String id_asiento;

        public MO_Ticket() { }

        public MO_Ticket(int id, int id_usuario, int id_cartelera, string id_asiento)
        {
            this.Id = id;
            this.Id_usuario = id_usuario;
            this.Id_cartelera = id_cartelera;
            this.Id_asiento = id_asiento;
        }

        public int Id { get => id; set => id = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_cartelera { get => id_cartelera; set => id_cartelera = value; }
        public string Id_asiento { get => id_asiento; set => id_asiento = value; }
    }
}
