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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Tarjeta_Credito = new ObservableListSource<Tarjeta_Credito>();
            this.Tickets = new ObservableListSource<Ticket>();
        }
    
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Password { get; set; }
        public int DNI { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Username { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Tarjeta_Credito> Tarjeta_Credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Ticket> Tickets { get; set; }
    }
}
