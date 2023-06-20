using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ListarPolizasUseCase
    {
        IRepoPoliza _repo;
        public ListarPolizasUseCase(IRepoPoliza repo)
        {
            _repo = repo;
        }
        public List<Poliza> Ejecutar()
        {
            return _repo.ListarPolizas();
        }
    }
}
