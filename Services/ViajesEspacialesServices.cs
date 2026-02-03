using System.Linq.Expressions;
using Luis_CortorrealAP1_P1.DAL;
using Luis_CortorrealAP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Luis_CortorrealAP1_P1.Services;

public class ViajesEspacialesServices(IDbContextFactory<Contexto>DbFactory)
{
    public async Task<bool> Guardar(ViajesEspaciales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> Existe(ViajesEspaciales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> insertar(ViajesEspaciales viajeEspaciales)
    {
        return true;
    }

    public async Task<bool> Modificar(ViajesEspaciales viajeEspaciales)
    {
        return true;
    }

    public async Task<ViajesEspaciales?> Buscar(ViajesEspaciales viajeEspaciales)
    {
        return null;
    }

    public async Task<bool> Eliminar(ViajesEspaciales viajeEspaciales)
    {
        return true;
    }

    public async Task<List<ViajesEspaciales>> Listar(Expression<Func<ViajesEspaciales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.ViajesEspaciales.Where(criterio).AsNoTracking().ToListAsync();
    }

}

