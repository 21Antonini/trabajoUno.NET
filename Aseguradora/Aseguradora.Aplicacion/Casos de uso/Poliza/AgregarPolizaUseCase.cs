using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class AgregarPolizaUseCase
    {
        IRepoPoliza _repo;
        public AgregarPolizaUseCase(IRepoPoliza repo)
        {
            _repo = repo;
        }
        public void Ejecutar(Poliza P)
        {
            _repo.AgregarPoliza(P);
        }
    }
}