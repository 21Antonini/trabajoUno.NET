using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseguradora.Repositorios;
public class RepoTercero : IRepoTercero
{
    public void AgregarTercero(Tercero tercero)
    {
        using (var db = new AseguradoraContext())
        {
            var terceroAgregar = db.Tercero.Where(t => t.DNI == tercero.DNI).SingleOrDefault();
            if (terceroAgregar == null)
            {
                db.Add(tercero);
                db.SaveChanges();
            }
            else { throw new Exception("El tercero ingresado ya existe."); }
        }
    }
    public void EliminarTercero(int idTercero)
    {
        using (var db = new AseguradoraContext())
        {
            var terceroBorrar = db.Titular.Where(t => t.ID == idTercero).SingleOrDefault();
            if (terceroBorrar != null)
            {
                db.Remove(terceroBorrar); 
                db.SaveChanges();
            }
            else { throw new Exception("El ID ingresado no corresponde a ningun tercero registrado."); }
        }
    }

    public void ModificarTercero(Tercero tercero)
    {
        using (var db = new AseguradoraContext())
        {
            var ter = db.Tercero.Where(n => n.ID == tercero.ID).SingleOrDefault();
            if (ter != null)
            {
                ter.DNI = tercero.DNI;
                ter.Nombre = tercero.Nombre; ;
                ter.Apellido = tercero.Apellido;
                ter.Telefono = tercero.Telefono;
                ter.Aseguradora = tercero.Aseguradora;
                ter.SiniestroID = tercero.SiniestroID;
                db.SaveChanges();
            }
            else { throw new Exception("El Tercero ingresado no corresponde a ninguno registrado."); };
        }
    }
    public Tercero ObtenerTercero(int idTercero)
    {
        Tercero resultado = new Tercero();
        using (var db = new AseguradoraContext())
        {
            var t = db.Tercero.Where(n => n.ID == idTercero).SingleOrDefault();
            if (t != null)
            {
                resultado = t;
            }
            else { throw new Exception("El Id ingresado no corresponde a ningun tercero registrado."); }
        }
        return resultado;
    }

    public List<Tercero> ListarTerceros()
    {
        List<Tercero> resultado = new List<Tercero>();
        using (var db = new AseguradoraContext())
        {
            resultado = db.Tercero.ToList();
        }
        return resultado;
    }
}
