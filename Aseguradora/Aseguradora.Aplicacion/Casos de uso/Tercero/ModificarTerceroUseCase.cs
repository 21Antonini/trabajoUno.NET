using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ModificarTerceroUseCase
    {
        IRepoTercero _repo;
        public ModificarTerceroUseCase(IRepoTercero repo)
        {
            _repo = repo;
        }
        public void Ejecutar(Tercero T)
        {
            _repo.ModificarTercero(T);
        }
    }
}