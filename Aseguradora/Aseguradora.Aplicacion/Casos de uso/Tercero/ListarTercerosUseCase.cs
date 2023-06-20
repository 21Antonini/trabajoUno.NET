using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ListarTercerosUseCase
    {
        IRepoTercero _repo;
        public ListarTercerosUseCase(IRepoTercero repo)
        {
            _repo = repo;
        }
        public List<Tercero> Ejecutar()
        {
            return _repo.ListarTerceros();
        }
    }
}