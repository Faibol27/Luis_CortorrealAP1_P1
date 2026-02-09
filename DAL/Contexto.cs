using Luis_CortorrealAP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Luis_CortorrealAP1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions options) : base(options) { }
    public DbSet<EntradasHuacales> EntradasHuacales { get; set; }
}

