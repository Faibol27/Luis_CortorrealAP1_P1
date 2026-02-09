using System.Linq.Expressions;
using Luis_CortorrealAP1_P1.DAL;
using Luis_CortorrealAP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Luis_CortorrealAP1_P1.Services;

public class EntradasHuacalesServices(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<bool> Guardar(EntradasHuacales Huacales)
    {
        return true;
    }

    public async Task<bool> Existe(string nombre, int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.AnyAsync(h => h.NombreCliente.ToLower() == nombre && h.IdEntrada != id);
    }

    public async Task<bool> Insertar(EntradasHuacales Huacales)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Add(Huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(EntradasHuacales Huacales)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Update(Huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<EntradasHuacales?> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.FirstOrDefaultAsync(h=>h.IdEntrada==id);
    }

    public async Task<bool> Eliminar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Where(h => h.IdEntrada == id).ExecuteDeleteAsync();
        return await contexto.SaveChangesAsync() > 0;

    }

    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.Where(criterio).AsNoTracking().ToListAsync();
    }

}

