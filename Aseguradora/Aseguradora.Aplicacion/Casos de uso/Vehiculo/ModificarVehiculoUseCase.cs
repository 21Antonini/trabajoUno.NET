using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class ModificarVehiculoUseCase
{
    IRepoVehiculo _repo;
    public ModificarVehiculoUseCase(IRepoVehiculo repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Vehiculo V)
    {
        _repo.ModificarVehiculo(V);
    }
}