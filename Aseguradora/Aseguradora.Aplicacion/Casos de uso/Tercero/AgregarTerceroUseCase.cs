namespace Aseguradora.Aplicacion;
public class AgregarTerceroUseCase
{
    IRepoTercero _repo;
    public AgregarTerceroUseCase(IRepoTercero repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Tercero T)
    {
        _repo.AgregarTercero(T);
    }
}