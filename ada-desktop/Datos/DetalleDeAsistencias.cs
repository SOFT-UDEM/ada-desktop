//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleDeAsistencias
    {
        public int IdDetalle { get; set; }
        public Nullable<int> IdAsistencia { get; set; }
        public Nullable<System.DateTime> FechaHoraEntrada { get; set; }
        public Nullable<System.DateTime> FechaHoraSalida { get; set; }
        public string Observacion { get; set; }
    
        public virtual Asistencias Asistencias { get; set; }
    }
}
