using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ModificarSiniestroUseCase
    {
        IRepoSiniestro _repo;
        public ModificarSiniestroUseCase(IRepoSiniestro repo)
        {
            _repo = repo;
        }
        public void Ejecutar(Siniestro S)
        {
            _repo.ModificarSiniestro(S);
        }
    }
}