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
    
    public partial class ReservaVisita
    {
        public int Id { get; set; }
        public Nullable<int> CantidadDeAlumnos { get; set; }
        public Nullable<int> CantidadDeAlumnosAConfirmar { get; set; }
        public string DuracionEstimada { get; set; }
        public Nullable<System.DateTime> FechaHoraCreacion { get; set; }
        public Nullable<System.DateTime> FechaHoraReserva { get; set; }
        public string HoraFinReal { get; set; }
        public string HoraInicioReal { get; set; }
        public string NumeroReserva { get; set; }
        public Nullable<int> IdSede { get; set; }
    
        public virtual Sede Sede { get; set; }
    }
}
