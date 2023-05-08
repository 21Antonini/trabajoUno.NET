namespace Aseguradora.Aplicacion;
public interface IRepoVehiculo
{
    public void AgregarVehiculo(Vehiculo V);
    public void ModificarVehiculo(Vehiculo V);
    public void EliminarVehiculo(string dominio);
    public List<Vehiculo> ListarVehiculos();
}