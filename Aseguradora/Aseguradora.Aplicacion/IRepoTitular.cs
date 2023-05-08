namespace Aseguradora.Aplicacion;
public interface IRepoTitular
{
    public void AgregarTitular(Titular T);
    public void ModificarTitular(Titular T);
    public void EliminarTitular(int Id);
    public List<Titular> ListarTitulares();
}