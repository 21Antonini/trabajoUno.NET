﻿using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Aseguradora.Repositorios;
public class RepoTitular : IRepoTitular
{
    public void AgregarTitular(Titular titular)
    {
        using (var db = new AseguradoraContext())
        {
            var titularAgregar = db.Titular.Where(t => t.DNI == titular.DNI).SingleOrDefault();
            if (titularAgregar == null)
            {
                db.Add(titular);
                db.SaveChanges();
            }
            else { throw new Exception("El titular ingresado ya existe."); }
        }
    }

    public void EliminarTitular(int idTitular)
    {
        using (var db = new AseguradoraContext())
        {
            var titularBorrar = db.Titular.Where(t => t.ID == idTitular).SingleOrDefault();
            if (titularBorrar != null)
            {
                db.Remove(titularBorrar); //se borra realmente con el db.SaveChanges()
                db.SaveChanges();
            }
            else { throw new Exception("El ID ingresado no corresponde a ningun titular registrado."); }
        }
    }


    public void ModificarTitular(Titular titular)
    {
        using (var db = new AseguradoraContext())
        {
            var titu = db.Titular.Where(n => n.ID == titular.ID).SingleOrDefault();
            if (titu != null)
            {
                titu.DNI = titular.DNI;
                titu.Nombre = titular.Nombre; ;
                titu.Apellido = titular.Apellido;
                titu.Telefono = titular.Telefono;
                titu.Direccion = titular.Direccion;
                db.SaveChanges();
            }
            else { throw new Exception("El Titular ingresado no corresponde a ninguno registrado."); };
        }
    }


    public List<Titular> ListarTitulares()
    {
        List<Titular> resultado = new List<Titular>();
        using (var db = new AseguradoraContext())
        {
            resultado = db.Titular.ToList();
        }
        return resultado;
    }

    public Titular ObtenerTitular(int idTitular)
    {
        Titular resultado = new Titular();
        using (var db = new AseguradoraContext()) 
        {
            var titu = db.Titular.Where(n => n.ID == idTitular).SingleOrDefault();
            if (titu != null)
            {
                resultado = titu;
            }
            else {throw new Exception("El Id ingresado no corresponde a ningun titular registrado."); }
        }
        return resultado;
    }

    public List<Titular> ListarTitularesConVehiculos(List<Vehiculo> vehiculos)
    {
        List<Titular> titularesConVehiculos = new List<Titular>();
        List<Titular> titulares = ListarTitulares();
        using (var db = new AseguradoraContext())
        {
            titularesConVehiculos = db.Titular.Include(t => t.listaVehiculos).ToList();
        }
            
        return titularesConVehiculos;
    }


}