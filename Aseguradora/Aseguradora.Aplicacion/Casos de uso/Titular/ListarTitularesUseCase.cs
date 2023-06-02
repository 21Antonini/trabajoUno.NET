using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class ListarTitularesUseCase
{
    IRepoTitular _repo;
    public ListarTitularesUseCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public List<Titular> Ejecutar()
    {
        return _repo.ListarTitulares();
    }
}