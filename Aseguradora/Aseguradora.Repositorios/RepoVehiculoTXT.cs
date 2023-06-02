using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepoVehiculoTXT : IRepoVehiculo
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("vehiculos.txt");
    private string? _idsPath = _obtenerPath("persistenciaIDs");
    public int determinarID()
    {
        using (StreamReader sr = new StreamReader(_idsPath))
        {
            string?[] ids = new string[3];
            //ids llevara un conteo de la cantidad de ids creada por cada entidad
            //ids[0] titulares
            //ids[1] polizas
            //ids[2] vehiculos
            ids = sr.ReadLine().Split(',');
            return Int32.Parse(ids[2]);
        }
    }
    public void actualizarID()
    {
        string?[] ids = new string[3];
        using (StreamReader sr = new StreamReader(_idsPath))
        {
            //ids llevara un conteo de la cantidad de ids creada por cada entidad
            //ids[0] titulares
            //ids[1] polizas
            //ids[2] vehiculos
            ids = sr.ReadLine().Split(',');
        }
        using (StreamWriter sw = new StreamWriter(_idsPath, true))
        {
            int aux = Int32.Parse(ids[2]);
            sw.WriteLine($"{ids[0]},{ids[1]},{aux++}");
        }
    }
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (StreamReader sr = new StreamReader(_path))
        {
            List<string[]> vehiculos = new List<string[]>();
            while (!sr.EndOfStream)
            {
                vehiculos.Add(sr.ReadLine().Split(','));
            }

            foreach (string[] st in vehiculos)
            {
                if (st[2].Equals(vehiculo.Dominio))
                {
                    throw new Exception("El dominio ingresado ya existe.");
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{determinarID},{vehiculo.idTitular},{vehiculo.Dominio},{vehiculo.Marca},{vehiculo.Fabricacion}");
            actualizarID();
        }
    }
    public void ModificarVehiculo(Vehiculo vehiculo)
    {
        List<string[]> vehiculos = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                vehiculos.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] vehiculoModificado = { vehiculo.ID.ToString(), vehiculo.idTitular.ToString(), vehiculo.Dominio, vehiculo.Marca, vehiculo.Fabricacion };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < vehiculos.Count)
            {
                if (vehiculos[cont][0].Equals(vehiculo.ID))
                {
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El Vehiculo ingresado no corresponde a ninguno registrado.");
            }
            else
            {
                foreach (string[] st in vehiculos)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public void EliminarVehiculo(int idVehiculo)
    {
        List<string[]> vehiculos = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                vehiculos.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < vehiculos.Count)
            {
                if (vehiculos[cont][0].Equals(idVehiculo))
                {
                    string[] vehiculoModificado = vehiculos[cont];
                    vehiculoModificado[0] = "*" + vehiculoModificado[0];
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El id ingresado no corresponde a ningun vehiculo registrado.");
            }
            else
            {
                foreach (string[] st in vehiculos)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public List<Vehiculo> ListarVehiculos()
    {
        List<Vehiculo> resultado = new List<Vehiculo>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (!st[0].Contains("*"))
                {
                    /*
                        st[0] Id 
                        st[1] Titular 
                        st[2] Dominio
                        st[3] Marca
                        st[4] Fabricacion
                     */
                    Vehiculo newVehiculo = new Vehiculo(st[2], st[3], st[4], st[1]);
                    newVehiculo.ID = Int32.Parse(st[0]);
                    resultado.Add(newVehiculo);
                }
            }
        }
        return resultado;
    }
}