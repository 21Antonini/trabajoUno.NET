using Aseguradora.Aplicacion.Interfaces;
using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion
{
    public class ListarTitularesConSusVehiculosUseCase
    {
        IRepoTitular _repoTitular;
        IRepoVehiculo _repoVehiculo;

        public ListarTitularesConSusVehiculosUseCase(IRepoTitular repoTitular, IRepoVehiculo repoVehiculo)
        {
            _repoTitular = repoTitular;
            _repoVehiculo = repoVehiculo;
        }

        //public List<Titular> Ejecutar()
        //{
        //    return _repoTitular.ListarTitularesConVehiculos(_repoVehiculo.ListarVehiculos());
        //}
    }
}
