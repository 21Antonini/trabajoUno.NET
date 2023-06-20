using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ObtenerTerceroUseCase
    {
        IRepoTercero _repo;
        public ObtenerTerceroUseCase(IRepoTercero repo)
        {
            _repo = repo;
        }
        public Tercero Ejecutar(int id)
        {
            return _repo.ObtenerTercero(id);
        }
    }
}
