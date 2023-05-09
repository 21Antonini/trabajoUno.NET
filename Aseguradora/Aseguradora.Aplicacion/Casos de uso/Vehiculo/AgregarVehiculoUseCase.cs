namespace Aseguradora.Aplicacion;
public class AgregarVehiculoUseCase
{
    IRepoVehiculo _repo;
    public AgregarVehiculoUseCase(IRepoVehiculo repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Vehiculo V)
    {
        _repo.AgregarVehiculo(V);
    }
}