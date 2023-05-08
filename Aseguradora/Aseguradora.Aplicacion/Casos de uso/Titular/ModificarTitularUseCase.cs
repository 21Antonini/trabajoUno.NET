namespace Aseguradora.Aplicacion;
public class ModificarTitularUseCase
{
    IRepoTitular _repo;
    public ModificarTitularUseCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Titular T)
    {
        _repo.ModificarTitular(T);
    }
}