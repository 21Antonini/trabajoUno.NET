using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase
{
    public class ObtenerVehiculoUseCase
    {
        IRepoVehiculo _repo;
        public ObtenerVehiculoUseCase(IRepoVehiculo repo)
        {
            _repo = repo;
        }
        public Vehiculo Ejecutar(int id)
        {
            return _repo.ObtenerVehiculo(id);
        }
    }
}