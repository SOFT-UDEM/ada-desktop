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
    
    public partial class EquiposTecnologicos
    {
        public int IdEquipo { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string NumeroDeSerie { get; set; }
        public string CodigoInterno { get; set; }
        public string Estado { get; set; }
        public Nullable<int> CodEmpleado { get; set; }
        public Nullable<decimal> ValorMonetario { get; set; }
        public Nullable<int> CreadoPorUserName { get; set; }
        public string Observacion { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
