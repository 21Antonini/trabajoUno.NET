using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseguradora.Repositorios;
public class RepoSiniestroTXT : IRepoSiniestro
{
    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var db = new AseguradoraContext())
        {

            var poliza = db.Poliza.Where(p => p.ID == siniestro.PolizaId).SingleOrDefault();
            if (poliza != null)
            {
                if ((siniestro.FechaOcurrencia >= poliza.VigenteDesde) && (siniestro.FechaOcurrencia <= poliza.VigenteHasta))
                {
                    db.Add(siniestro);
                    db.SaveChanges();
                }
                else { throw new Exception("No se puede agregar Siniestro por fecha de vigencia de la Poliza"); }
            }
            else { throw new Exception("No se puede agregar Siniestro. No existe Poliza con dicho Id"); }
        }
    }

    public void EliminarSiniestro(int idSiniestro)
    {
        using (var db = new AseguradoraContext())
        {
            var siniestroBorrar = db.Titular.Where(s => s.ID == idSiniestro).SingleOrDefault();
            if (siniestroBorrar != null)
            {
                db.Remove(siniestroBorrar);
                db.SaveChanges();
            }
            else { throw new Exception("El ID ingresado no corresponde a ningun siniestro registrada."); }
        }
    }
    public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var db = new AseguradoraContext())
        {
            var sin = db.Siniestro.Where(n => n.ID == siniestro.ID).SingleOrDefault();
            if (sin != null)
            {
                sin.PolizaId = siniestro.PolizaId; ;
                sin.FechaCargaSistema = siniestro.FechaCargaSistema;
                sin.FechaOcurrencia = siniestro.FechaOcurrencia;
                sin.DireccionDelHecho = siniestro.DireccionDelHecho;
                sin.DescripcionDelHecho = siniestro.DescripcionDelHecho;
                db.SaveChanges();
            }
            else { throw new Exception("El Siniestro ingresado no corresponde a ninguno registrado."); };
        }
    }
    public Siniestro ObtenerSiniestro(int idSiniestro)
    {
        Siniestro resultado = new Siniestro();
        using (var db = new AseguradoraContext())
        {
            var t = db.Siniestro.Where(n => n.ID == idSiniestro).SingleOrDefault();
            if (t != null)
            {
                resultado = t;
            }
            else { throw new Exception("El Id ingresado no corresponde a ningun siniestro registrado."); }
        }
        return resultado;
    }


    public List<Siniestro> ListarSiniestros()
    {
        List<Siniestro> resultado = new List<Siniestro>();
        using (var db = new AseguradoraContext()) 
        {
            resultado = db.Siniestro.ToList();   
        }
        return resultado;
    }
}   
