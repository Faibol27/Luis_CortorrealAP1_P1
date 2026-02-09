using System.Linq.Expressions;
using Luis_CortorrealAP1_P1.DAL;
using Luis_CortorrealAP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Luis_CortorrealAP1_P1.Services;

public class ViajesEspacialesServices(IDbContextFactory<Contexto>DbFactory)
{
    public async Task<bool> Guardar(EntradasHuacales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> Existe(EntradasHuacales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> insertar(EntradasHuacales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> Modificar(EntradasHuacales viajeEspaciales)
    {
        return true;
    }

    public async Task<EntradasHuacales?> Buscar(EntradasHuacales viajeEspaciales)
    {
        return null;
    }

    public async Task<bool> Eliminar(EntradasHuacales viajeEspaciales)
    {
        return true;
    }

    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.Where(criterio).AsNoTracking().ToListAsync();
    }

}

