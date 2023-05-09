namespace Aseguradora.Aplicacion;
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