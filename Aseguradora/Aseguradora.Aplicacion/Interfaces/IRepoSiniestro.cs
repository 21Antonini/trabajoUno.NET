using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepoSiniestro
{
    public void AgregarSiniestro(Siniestro T, Poliza P);
    public void ModificarSiniestro(Siniestro T);
    public void EliminarSiniestro(int idSiniestro);
    public Siniestro ObtenerSiniestro(int idSiniestro);
    public List<Siniestro> ListarSiniestros();
}