using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Equipo
    {
        public int id { get; set; }
        public string? Nombre { get; set; }
        public string? Pais { get; set; }
        public string? Estadio { get; set; }
        public string? Ciudad { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCampeonatos { get; set; }
        public bool Activo { get; set; }
    }
}
