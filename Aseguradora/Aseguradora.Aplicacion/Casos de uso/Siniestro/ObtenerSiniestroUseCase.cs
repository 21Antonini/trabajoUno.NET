using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ObtenerSiniestroUseCase
    {
        IRepoSiniestro _repo;
        public ObtenerSiniestroUseCase(IRepoSiniestro repo)
        {
            _repo = repo;
        }
        public Siniestro Ejecutar(int id)
        {
            return _repo.ObtenerSiniestro(id);
        }
    }
}
