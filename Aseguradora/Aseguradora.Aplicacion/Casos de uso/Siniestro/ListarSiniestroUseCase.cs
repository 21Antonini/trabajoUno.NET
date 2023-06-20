using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ListarSiniestroUseCase
    {
        IRepoSiniestro _repo;
        public ListarSiniestroUseCase(IRepoSiniestro repo)
        {
            _repo = repo;
        }
        public List<Siniestro> Ejecutar()
        {
            return _repo.ListarSiniestros();
        }
    }
}