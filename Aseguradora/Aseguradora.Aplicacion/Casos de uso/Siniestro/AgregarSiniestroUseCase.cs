using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion;
public class AgregarSiniestroUseCase
{
    IRepoSiniestro _repoSiniestro;
    IRepoPoliza _repoPoliza;
    public AgregarSiniestroUseCase(IRepoSiniestro repoSiniestro, IRepoPoliza repoPoliza)
    {
        _repoSiniestro = repoSiniestro;
        _repoPoliza = repoPoliza;

    }
    public void Ejecutar(Siniestro S)
    {
        _repoSiniestro.AgregarSiniestro(S, _repoPoliza.ListarPolizas());
    }
}