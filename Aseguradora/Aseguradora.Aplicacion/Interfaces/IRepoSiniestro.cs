using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepoSiniestro
{
    public void AgregarSiniestro(Siniestro T);
    public void ModificarSiniestro(Siniestro T);
    public void EliminarSiniestro(int idSiniestro);
    public List<Siniestro> ListarSiniestros();
}