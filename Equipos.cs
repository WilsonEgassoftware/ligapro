using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Ligapro.Models
{
    public class Equipos
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [DisplayName("NOmbre del Equipo")]
        [Required]
        public string nombre { get; set; }
        [Range(0, 20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int Puntos {

            get
            {
                int Puntos = PartidosGanados * 3 + PartidosEmpatados * 1;
                return Puntos;


            }




        }
    }
}
