/*using Aseguradora.Aplicacion;

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
            sw.WriteLine($"{vehiculo.Dueño},{vehiculo.Dominio},{vehiculo.Marca},{vehiculo.Fabricacion}");
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
            string[] vehiculoModificado = {vehiculo.Dueño.ToString(),vehiculo.Dominio,vehiculo.Marca,vehiculo.Fabricacion};
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < vehiculos.Count)
            {
                if (vehiculos[cont][1].Equals(vehiculo.Dominio))
                {
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El Dominio ingresado no corresponde a ninguno registrado.");
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
    public void EliminarVehiculo(string dominio)
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
                if (vehiculos[cont][1].Equals(dominio))
                {
                    string[] vehiculoModificado = vehiculos[cont];
                    vehiculoModificado[1] = "*" + vehiculoModificado[1];
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El dominio ingresado no corresponde a ninguno registrado.");
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
                        st[0] Dueño 
                        st[1] Dominio
                        st[2] Marca
                        st[3] Fabricacion
                     */
                    Vehiculo newVehiculo = new Vehiculo(st[1], st[2], st[3], Int32.Parse(st[0]));
                    resultado.Add(newVehiculo);
                }
            }
        }
        return resultado;
    }
}*/