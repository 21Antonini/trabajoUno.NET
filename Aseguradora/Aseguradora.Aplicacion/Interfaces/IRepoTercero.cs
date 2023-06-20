using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepoTercero
{
    public void AgregarTercero(Tercero T);
    public void ModificarTercero(Tercero T);
    public void EliminarTercero(int Id);
    public Tercero ObtenerTercero(int id);

    public List<Tercero> ListarTerceros();
}