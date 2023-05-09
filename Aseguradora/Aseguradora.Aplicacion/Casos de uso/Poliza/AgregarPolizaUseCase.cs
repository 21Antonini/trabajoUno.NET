namespace Aseguradora.Aplicacion;
public class AgregarPolizaUseCase
{
    IRepoPoliza _repo;
    public AgregarPolizaUseCase(IRepoPoliza repo)
    {
        _repo = repo;
    }
    public void Ejecutar(Poliza P)
    {
        _repo.AgregarPoliza(P);
    }
}