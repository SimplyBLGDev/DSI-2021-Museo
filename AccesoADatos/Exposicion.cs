//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exposicion
    {
        public Exposicion()
        {
            this.DetalleExposicion = new HashSet<DetalleExposicion>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.DateTime> FechaFinReplanificacion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaInicioReplanificacion { get; set; }
        public string HoraApertura { get; set; }
        public string HoraCierra { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdSede { get; set; }
    
        public virtual ICollection<DetalleExposicion> DetalleExposicion { get; set; }
        public virtual Sede Sede { get; set; }
    }
}