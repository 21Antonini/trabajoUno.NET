namespace Aseguradora.Aplicacion;
public interface IRepoVehiculo
{
    public void AgregarVehiculo(Vehiculo V);
    public void ModificarVehiculo(Vehiculo V);
    public void EliminarVehiculo(int idVehiculo);
    public List<Vehiculo> ListarVehiculos();
}