using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class AgregarTitularUseCase
{
    IRepoTitular _repo;
    public AgregarTitularUseCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public void ejecutar(Titular t)
    {
        _repo.AgregarTitular(t);
    }
}