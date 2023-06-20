using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ListarVehiculosUseCase
    {
        IRepoVehiculo _repo;
        public ListarVehiculosUseCase(IRepoVehiculo repo)
        {
            _repo = repo;
        }
        public List<Vehiculo> Ejecutar()
        {
            return _repo.ListarVehiculos();
        }
    }
}