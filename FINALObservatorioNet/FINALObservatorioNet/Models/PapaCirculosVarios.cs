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
    
    public partial class PapaCirculosVarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PapaCirculosVarios()
        {
            this.HijoCirculosVarios = new HashSet<HijoCirculosVarios>();
        }
    
        public int IdPadre { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> IdAbueloFK { get; set; }
        public string Color { get; set; }
        public string tooltipRegion { get; set; }
        public string tooltipGastoNominal { get; set; }
        public string tooltipGastoPercapita { get; set; }
        public Nullable<int> Montonominal { get; set; }
        public Nullable<int> MontoPercapita { get; set; }
        public Nullable<int> sizePercapita { get; set; }
        public string Proper1 { get; set; }
        public Nullable<int> Size { get; set; }
        public string Proper2 { get; set; }
        public string TituloConsulta { get; set; }
    
        public virtual AbueloCirculosVarios AbueloCirculosVarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HijoCirculosVarios> HijoCirculosVarios { get; set; }
    }
}
