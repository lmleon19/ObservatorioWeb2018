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
    
    public partial class DatosdupliCirculosVarios
    {
        public int IdDatos { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> IdGraficoFK { get; set; }
        public Nullable<int> numeroOpcion { get; set; }
    
        public virtual GraficoCircularesVarios GraficoCircularesVarios { get; set; }
    }
}
