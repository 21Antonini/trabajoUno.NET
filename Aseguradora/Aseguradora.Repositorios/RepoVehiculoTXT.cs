using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoVehiculoTXT : IRepoVehiculo
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("vehiculos.txt");
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{vehiculo.id},{vehiculo.idTitular},{vehiculo.Dominio},{vehiculo.Marca},{vehiculo.Fabricacion}");
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
            string[] vehiculoModificado = { vehiculo.id.ToString(), vehiculo.idTitular.ToString(), vehiculo.Dominio, vehiculo.Marca, vehiculo.Fabricacion };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < vehiculos.Count)
            {
                if (vehiculos[cont][1].Equals(vehiculo.id))
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
        Titular.ID = 0;
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (st[0].Contains("*"))
                {
                    Vehiculo.ID++;
                }
                else
                {
                    /*
                        st[0] Id 
                        st[1] Titular 
                        st[2] Dominio
                        st[3] Marca
                        st[4] Fabricacion
                     */
                    Vehiculo newVehiculo = new Vehiculo(st[2], st[3], st[4], Int32.Parse(st[1]));
                    resultado.Add(newVehiculo);
                }
            }
        }
        return resultado;
    }

    public List<Vehiculo> vehiculosDelTitular(int id)
    {

    }
}