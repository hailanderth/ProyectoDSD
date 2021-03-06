//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MD.GA.BE.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documento()
        {
            this.Documento_Articulo = new HashSet<Documento_Articulo>();
        }
    
        public int Id_Documento { get; set; }
        public string TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public Nullable<int> Id_Sede { get; set; }
        public Nullable<int> Id_DocumentoOrigen { get; set; }
        public string FormaPago { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> MontoTotal { get; set; }
        public string Encargado { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Estado { get; set; }
        public string TipoPresupuesto { get; set; }
        public Nullable<decimal> MontoDisponible { get; set; }
    
        public virtual Sede Sede { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento_Articulo> Documento_Articulo { get; set; }
    }
}
