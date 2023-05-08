namespace Aseguradora.Aplicacion;
public class EliminarTitularUseCase
{
    IRepoTitular _repo;
    public EliminarTitularUseCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public void Ejecutar(int ID)
    {
        _repo.EliminarTitular(ID);
    }
}