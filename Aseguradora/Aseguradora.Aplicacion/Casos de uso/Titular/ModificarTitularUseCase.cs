using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ModificarTitularUseCase
    {
        IRepoTitular _repo;
        public ModificarTitularUseCase(IRepoTitular repo)
        {
            _repo = repo;
        }
        public void Ejecutar(Titular T)
        {
            _repo.ModificarTitular(T);
        }
    }
}