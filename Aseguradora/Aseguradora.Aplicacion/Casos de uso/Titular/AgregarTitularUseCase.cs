using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class AgregarTitularUseCase
    {
        IRepoTitular _repo;
        public AgregarTitularUseCase(IRepoTitular repo)
        {
            _repo = repo;
        }
        public void Ejecutar(Titular t)
        {
            _repo.AgregarTitular(t);
        }
    }
}