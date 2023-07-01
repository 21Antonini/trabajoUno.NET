using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepoPoliza : IRepoPoliza
{
    public void AgregarPoliza(Poliza poliza)
    {
        using (var db = new AseguradoraContext())
        {
            var polizaAgregar = db.Poliza.Where(p => p.VehiculoId == poliza.VehiculoId).SingleOrDefault();
            if (polizaAgregar == null)
            {
                db.Add(poliza);
                db.SaveChanges();
            }
            else { throw new Exception("La poliza ingresada ya existe."); }
        }
    }
    public void EliminarPoliza(int idPoliza)
    {
        using (var db = new AseguradoraContext())
        {
            var polizaBorrar = db.Titular.Where(p => p.ID == idPoliza).SingleOrDefault();
            if (polizaBorrar != null)
            {
                db.Remove(polizaBorrar);
                db.SaveChanges();
            }
            else { throw new Exception("El ID ingresado no corresponde a ninguna poliza registrada."); }
        }
    }
    public void ModificarPoliza(Poliza poliza)
    {
        using (var db = new AseguradoraContext())
        {
            var pol = db.Poliza.Where(n => n.ID == poliza.ID).SingleOrDefault();
            if (pol != null)
            {
                pol.VehiculoId = poliza.VehiculoId;
                pol.valorAsegurado = poliza.valorAsegurado; ;
                pol.Franquicia = poliza.Franquicia;
                pol.Cobertura = poliza.Cobertura;
                pol.VigenteDesde = poliza.VigenteDesde;
                pol.VigenteHasta = poliza.VigenteHasta;
                db.SaveChanges();
            }
            else { throw new Exception("La poliza ingresada no corresponde a ninguna registrada."); };
        }
    }

    public Poliza ObtenerPoliza(int idPoliza)
    {
        Poliza resultado = new Poliza();
        using (var db = new AseguradoraContext())
        {
            var t = db.Poliza.Where(n => n.ID == idPoliza).SingleOrDefault();
            if (t != null)
            {
                resultado = t;
            }
            else { throw new Exception("El Id ingresado no corresponde a ninguna poliza registrada."); }
        }
        return resultado;
    }

    public List<Poliza> ListarPolizas()
    {
        List<Poliza> resultado = new List<Poliza>();
        using (var db = new AseguradoraContext())
        {
            resultado = db.Poliza.ToList();
        }
        return resultado;
    }
}