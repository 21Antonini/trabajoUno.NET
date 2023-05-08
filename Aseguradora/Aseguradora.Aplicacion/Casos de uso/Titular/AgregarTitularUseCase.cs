namespace Aseguradora.Aplicacion;
public class AgregarTitularUseCase
{
    IRepoTitular _repo;
    public AgregarTitularUseCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Titular T)
    {
        _repo.AgregarTitular(T);
    }
}