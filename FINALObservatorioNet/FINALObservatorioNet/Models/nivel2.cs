//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FINALObservatorioNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nivel2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nivel2()
        {
            this.nivel3 = new HashSet<nivel3>();
        }
    
        public int IdNivel2 { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Valor { get; set; }
        public Nullable<bool> Tipo { get; set; }
        public Nullable<int> Fk_IdNivel1 { get; set; }
        public Nullable<int> Valor2 { get; set; }
        public string PorcentajeGastadoAlPapa { get; set; }
        public string PorcentajePresupeustadoAlPapa { get; set; }
        public string Descripcion { get; set; }
    
        public virtual nivel1 nivel1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nivel3> nivel3 { get; set; }
    }
}
