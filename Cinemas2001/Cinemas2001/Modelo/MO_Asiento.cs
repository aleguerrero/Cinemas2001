using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Asiento
    {
        String id, id_Sala;
        private int numero;

        public MO_Asiento() { }

        public MO_Asiento(string id, string id_Sala, int numero)
        {
            this.Id = id;
            this.Id_Sala = id_Sala;
            this.Numero = numero;
        }

        public string Id { get => id; set => id = value; }
        public string Id_Sala { get => id_Sala; set => id_Sala = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
