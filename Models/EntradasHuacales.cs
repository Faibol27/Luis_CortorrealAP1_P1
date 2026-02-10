using System.ComponentModel.DataAnnotations;

namespace Luis_CortorrealAP1_P1.Models;

public class EntradasHuacales
{
    [Key]
    public int IdEntrada { get; set; }


    [Required(ErrorMessage = "Este campo es requerido")]
    public string NombreCliente { get; set; }

    [Required(ErrorMessage = "Este campo es requerido")]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "Este campo es requerido")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Este campo es requerido")]
    public double Precio { get; set; }

}

