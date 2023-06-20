using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Repositorios;
public class AseguradoraContext : DbContext
{

    public DbSet<Titular> Titular { get; set; }
    public DbSet<Vehiculo> Vehiculo { get; set; }
    public DbSet<Siniestro> Siniestro { get; set; }
    public DbSet<Poliza> Poliza { get; set; }
    public DbSet<Tercero> Tercero { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}
