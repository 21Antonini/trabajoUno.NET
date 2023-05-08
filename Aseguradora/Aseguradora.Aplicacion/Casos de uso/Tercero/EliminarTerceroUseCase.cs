namespace Aseguradora.Aplicacion;
public class EliminarTerceroUseCase
{
    IRepoTercero _repo;
    public EliminarTerceroUseCase(IRepoTercero repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Tercero T)
    {
        _repo.EliminarTercero(T);
    }
}