namespace Aseguradora.Aplicacion;
public interface IRepoPoliza
{
    public void AgregarPoliza(Poliza P);
    public void ModificarPoliza(Poliza P);
    public void EliminarPoliza(int Id);
    public List<Poliza> ListarPolizas();
}