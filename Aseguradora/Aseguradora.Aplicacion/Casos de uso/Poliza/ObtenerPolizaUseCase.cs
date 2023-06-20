using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ObtenerPolizaUseCase
    {
        IRepoPoliza _repo;
        public ObtenerPolizaUseCase(IRepoPoliza repo)
        {
            _repo = repo;
        }
        public Poliza Ejecutar(int id)
        {
            return _repo.ObtenerPoliza(id);
        }
    }
}