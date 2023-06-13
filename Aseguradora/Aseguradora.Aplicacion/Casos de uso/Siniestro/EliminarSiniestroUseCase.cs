using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class EliminarSiniestroUseCase
{
    IRepoSiniestro _repo;
    public EliminarSiniestroUseCase(IRepoSiniestro repo)
    {
        _repo = repo;
    }
    public void Ejecutar(int ID)
    {
        _repo.EliminarSiniestro(ID);
    }
}