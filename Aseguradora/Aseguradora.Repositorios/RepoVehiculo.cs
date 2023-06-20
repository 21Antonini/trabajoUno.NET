using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepoVehiculoTXT : IRepoVehiculo
{
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var vehiculoAgregar = db.Vehiculo.Where(v => v.Dominio == vehiculo.Dominio).SingleOrDefault();
            if (vehiculoAgregar == null)
            {
                db.Add(vehiculo);
                db.SaveChanges();
            }
            else { throw new Exception("El vehiculo ingresado ya existe."); }
        }
    }
    public void EliminarVehiculo(int idVehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var vehiculoBorrar = db.Vehiculo.Where(v => v.ID == idVehiculo).SingleOrDefault();
            if (vehiculoBorrar != null)
            {
                db.Remove(vehiculoBorrar);
                db.SaveChanges();
            }
            else { throw new Exception("El ID ingresado no corresponde a ningun vehiculo registrado."); }
        }
    }

    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        using (var db = new AseguradoraContext())
        {
            var vehi = db.Vehiculo.Where(v => v.ID == vehiculo.ID).SingleOrDefault();
            if (vehi != null)
            {
                vehi.Dominio = vehiculo.Dominio;
                vehi.Marca = vehiculo.Marca; ;
                vehi.Fabricacion = vehiculo.Fabricacion;
                vehi.TitularId = vehiculo.TitularId;
                db.SaveChanges();
            }
            else { throw new Exception("El Vehiculo ingresado no corresponde a ninguno registrado."); };
        }
    }

    public Vehiculo ObtenerVehiculo(int idVehiculo)
    {
        Vehiculo resultado = new Vehiculo();
        using (var db = new AseguradoraContext())
        {
            var veh = db.Vehiculo.Where(n => n.ID == idVehiculo).SingleOrDefault();
            if (veh != null)
            {
                resultado = veh;
            }
            else { throw new Exception("El Id ingresado no corresponde a ningun vehiculo registrado."); }
        }
        return resultado;
    }

    public List<Vehiculo> ListarVehiculos()
    {
        List<Vehiculo> resultado = new List<Vehiculo>();
        using (var db = new AseguradoraContext())
        {
            resultado = db.Vehiculo.ToList();
        }
        return resultado;
    }
}