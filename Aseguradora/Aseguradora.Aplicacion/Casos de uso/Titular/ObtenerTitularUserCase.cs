using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseguradora.Aplicacion;
public class ObtenerTitularUserCase
{
    IRepoTitular _repo;
    public ObtenerTitularUserCase(IRepoTitular repo)
    {
        _repo = repo;
    }
    public Titular Ejecutar(int id)
    {
        return _repo.ObtenerTitular(id);
    }
}