using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ObtenerTitularUseCase
    {
        IRepoTitular _repo;
        public ObtenerTitularUseCase(IRepoTitular repo)
        {
            _repo = repo;
        }
        public Titular Ejecutar(int id)
        {
            return _repo.ObtenerTitular(id);
        }
    }
}