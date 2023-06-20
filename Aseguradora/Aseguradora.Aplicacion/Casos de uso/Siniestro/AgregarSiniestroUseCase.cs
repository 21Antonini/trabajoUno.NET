using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UserCase{
public class AgregarSiniestroUseCase
{
    IRepoSiniestro _repoSiniestro;
    IRepoPoliza _repoPoliza;
    public AgregarSiniestroUseCase(IRepoSiniestro repoSiniestro)
    {
        _repoSiniestro = repoSiniestro;

    }
    public void Ejecutar(Siniestro S)
    {
        _repoSiniestro.AgregarSiniestro(S);
    }
}
}