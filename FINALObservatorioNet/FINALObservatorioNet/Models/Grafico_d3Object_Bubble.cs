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
    
    public partial class Grafico_d3Object_Bubble
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grafico_d3Object_Bubble()
        {
            this.Circulos_Grafico_d3Object_Bubble = new HashSet<Circulos_Grafico_d3Object_Bubble>();
        }
    
        public int IdGrafico { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ano { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Circulos_Grafico_d3Object_Bubble> Circulos_Grafico_d3Object_Bubble { get; set; }
    }
}
