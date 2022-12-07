using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IPagos.Models
{
    internal class Pagos
    {
        [JsonPropertyName("NumeroMatricula")]
        public string NumeroMatricula { get; set; } = null!;
        [JsonPropertyName("TipoPago")]
        public string TipoPago { get; set; } = null!;
        [JsonPropertyName("Institucion")]
        public string Institucion { get; set; } = null!;
        [JsonPropertyName("Descripcion")]
        public string Descripcion { get; set; } = null!;
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; } = null!;
        [JsonPropertyName("Apellidos")]
        public string Apellidos { get; set; } = null!;
        [JsonPropertyName("Fecha")]
        public string Fecha { get; set; } = null!;
        
    }
}
