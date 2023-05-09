namespace Aseguradora.Aplicacion;
public class EliminarVehiculoUseCase
{
    IRepoVehiculo _repo;
    public EliminarVehiculoUseCase(IRepoVehiculo repo)
    {
        _repo = repo;
    }
    public void Ejecutar(int ID)
    {
        _repo.EliminarVehiculo(ID);
    }
}