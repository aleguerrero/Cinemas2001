//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinemas2001.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int id_Ticket { get; set; }
        public int id_Usuario { get; set; }
        public int id_Horario { get; set; }
        public string nom_pelicula { get; set; }
        public System.TimeSpan horario { get; set; }
    
        public virtual Horario Horario1 { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
