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
    
    public partial class Tabla_amChart_HorizontalBar
    {
        public int idtabla { get; set; }
        public string Iniciativa { get; set; }
        public Nullable<int> valorNominal { get; set; }
        public Nullable<int> valorPercapita { get; set; }
        public Nullable<int> idlinea { get; set; }
        public string Idregion { get; set; }
    
        public virtual Barra_amChart_HorizontalBar Barra_amChart_HorizontalBar { get; set; }
    }
}
