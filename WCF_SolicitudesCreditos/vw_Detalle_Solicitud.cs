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
    
    public partial class vw_Detalle_Solicitud
    {
        public string Id_solicitud { get; set; }
        public string Id_cli { get; set; }
        public string Nombre_cliente { get; set; }
        public string Nom_cli { get; set; }
        public string Ape_cli { get; set; }
        public string Id_analista { get; set; }
        public string Nombre_analista { get; set; }
        public string PRODUCTO { get; set; }
        public Nullable<int> Tipo_producto { get; set; }
        public System.DateTime Fec_solicitud { get; set; }
        public Nullable<decimal> Monto_solici { get; set; }
        public string Num_cuenta { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Est_solicitud { get; set; }
        public Nullable<System.DateTime> Fec_aprobacion { get; set; }
        public Nullable<System.DateTime> Fec_rechazo { get; set; }
        public string Motivo_rechazo { get; set; }
        public string Estado_desembolso { get; set; }
        public Nullable<int> Cuotas { get; set; }
        public Nullable<int> Est_desembolso { get; set; }
        public Nullable<System.DateTime> Fec_desembolso { get; set; }
        public Nullable<System.DateTime> Fec_pago { get; set; }
    }
}
