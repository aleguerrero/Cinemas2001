using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas2001.Modelo
{
    class MO_Tarjeta_Credito
    {
        private int numero_Tarjeta, id_Usuario, cvo;
        private virtual Usuario vUsuario;

        public MO_Tarjeta_Credito() { }

        public MO_Tarjeta_Credito(int numero_Tarjeta, int id_Usuario, int cvo)
        {
            this.Numero_Tarjeta = numero_Tarjeta;
            this.Id_Usuario = id_Usuario;
            this.Cvo = cvo;
        }

        public int Numero_Tarjeta { get => numero_Tarjeta; set => numero_Tarjeta = value; }
        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public int Cvo { get => cvo; set => cvo = value; }
        public Usuario VUsuario { get => vUsuario; set => vUsuario = value; }
    }
}
