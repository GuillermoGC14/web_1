using System;
using System.Collections.Generic;

namespace database_first1.Models
{
    public partial class Libro
    {
        public int LibId { get; set; }
        public string LibNombre { get; set; } = null!;
        public string LibAutor { get; set; } = null!;
        public string LibGenero { get; set; } = null!;
        public string LibTipoProyecto { get; set; } = null!;
        public string LibStatus { get; set; } = null!;
    }
}
