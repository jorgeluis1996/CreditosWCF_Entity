//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_SolicitudesCreditos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Agencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Agencia()
        {
            this.Tb_Analista = new HashSet<Tb_Analista>();
        }
    
        public string Id_agencia { get; set; }
        public string Id_ubigeo { get; set; }
        public string Nom_agencia { get; set; }
        public string Agen_direccion { get; set; }
    
        public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Analista> Tb_Analista { get; set; }
    }
}
