using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class AgregarSiniestroUseCase
{
    IRepoSiniestro _repo;
    public AgregarSiniestroUseCase(IRepoSiniestro repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Siniestro S)
    {
        _repo.AgregarSiniestro(S);
    }
}