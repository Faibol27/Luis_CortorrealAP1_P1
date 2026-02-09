using System.ComponentModel.DataAnnotations;

namespace Luis_CortorrealAP1_P1.Models;

public class EntradasHuacales
{
    [Key]
    public int IdEntrada { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    [Required]
    public string NombreCliente { get; set; }

    [Required]
    public int Cantidad { get; set; }

    [Required]
    public double Precio { get; set; }


}

