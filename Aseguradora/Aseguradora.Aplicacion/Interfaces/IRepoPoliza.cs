using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepoPoliza
{
    public void AgregarPoliza(Poliza P);
    public void ModificarPoliza(Poliza P);
    public void EliminarPoliza(int Id);
    public Poliza ObtenerPoliza(int idPoliza);
    List<Poliza> ListarPolizas();
}