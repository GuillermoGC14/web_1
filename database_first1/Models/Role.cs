using System;
using System.Collections.Generic;

namespace database_first1.Models
{
    public partial class Role
    {
        public Role()
        {
            PersonajePerLibs = new HashSet<Personaje>();
            PersonajePerRols = new HashSet<Personaje>();
        }

        public int RolId { get; set; }
        public string RolDescripcion { get; set; } = null!;
        public string RolStatus { get; set; } = null!;

        public virtual ICollection<Personaje> PersonajePerLibs { get; set; }
        public virtual ICollection<Personaje> PersonajePerRols { get; set; }
    }
}
