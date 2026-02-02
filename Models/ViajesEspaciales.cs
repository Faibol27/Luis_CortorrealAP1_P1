using System.ComponentModel.DataAnnotations;

namespace Luis_CortorrealAP1_P1.Models;

    public class ViajesEspaciales
    {
        [Key]
        public int ViajeId { get; set; }

        [Required] 
        public String Descripcion { get; set; }

        [Required] 
        public DateTime Fecha { get; set; }

        [Required] 
        public double Precio { get; set; }
    }

