using System.ComponentModel.DataAnnotations;

namespace Luis_CortorrealAP1_P1.Models;

public class ViajesEspaciales
{
    [Key]
    public int ViajeId { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    public string Descripcion { get; set; }

    [Required]
    public double Costo { get; set; }


}

