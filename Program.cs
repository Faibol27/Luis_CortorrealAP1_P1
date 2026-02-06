using Blazored.Toast;
using Luis_CortorrealAP1_P1.Components;
using Luis_CortorrealAP1_P1.DAL;
using Luis_CortorrealAP1_P1.Models;
using Luis_CortorrealAP1_P1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazoredToast();

var SqlCon = builder.Configuration.GetConnectionString("SqlConStr");
builder.Services.AddDbContextFactory<Contexto>(v => v.UseSqlServer(SqlCon));
builder.Services.AddScoped<ViajesEspacialesServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
