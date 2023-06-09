using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class EliminarPolizaUseCase
    {
        IRepoPoliza _repo;
        public EliminarPolizaUseCase(IRepoPoliza repo)
        {
            _repo = repo;
        }
        public void Ejecutar(int ID)
        {
            _repo.EliminarPoliza(ID);
        }
    }
}