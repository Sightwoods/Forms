using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoCuentas.Models
{
    internal class Pagos
    {

        public string? Id { get; set; }
        public string NumeroMatricula { get; set; } = null!;
        public string TipoPago { get; set; } = null!;
        public string Institucion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        
    }
}
