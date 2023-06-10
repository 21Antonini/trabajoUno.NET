using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepoTitular
{
    public void AgregarTitular(Titular T);
    public void ModificarTitular(Titular T);
    public void EliminarTitular(int Id);
    public List<Titular> ListarTitulares();
    public List<Titular> ListarTitularesConVehiculos(List<Vehiculo> vehiculos);
}