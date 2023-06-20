using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class ModificarPolizaUseCase
{
    IRepoPoliza _repo;
    public ModificarPolizaUseCase(IRepoPoliza repo)
    {
        _repo = repo;
    }
    //public void Ejecutar(Poliza P)
    //{
    //    _repo.ModificarPoliza(P);
    //}
}