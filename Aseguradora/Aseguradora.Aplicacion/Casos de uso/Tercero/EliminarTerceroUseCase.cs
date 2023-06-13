using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class EliminarTerceroUseCase
{
    IRepoTercero _repo;
    public EliminarTerceroUseCase(IRepoTercero repo)
    {
        _repo = repo;
    }
    public void Ejecutar(int ID)
    {
        _repo.EliminarTercero(ID);
    }
}