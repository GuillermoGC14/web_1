using System;
using System.Collections.Generic;

namespace database_first1.Models
{
    public partial class Personaje
    {
        public int PerId { get; set; }
        public int PerLibId { get; set; }
        public int PerRolId { get; set; }
        public string PerNombre { get; set; } = null!;
        public string PerApellido { get; set; } = null!;
        public string PerDescripcion { get; set; } = null!;
        public DateTime? PerFechaNacimiento { get; set; }
        public string? PerLugarNacimiento { get; set; }
        public string PerStatus { get; set; } = null!;

        public virtual Role PerLib { get; set; } = null!;
        public virtual Role PerRol { get; set; } = null!;
    }
}
