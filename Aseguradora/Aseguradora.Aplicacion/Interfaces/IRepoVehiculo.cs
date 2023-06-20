using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepoVehiculo
{
    public void AgregarVehiculo(Vehiculo V);
    public void ModificarVehiculo(Vehiculo V);
    public void EliminarVehiculo(int idVehiculo);
    public Vehiculo ObtenerVehiculo(int id);

    public List<Vehiculo> ListarVehiculos();
}