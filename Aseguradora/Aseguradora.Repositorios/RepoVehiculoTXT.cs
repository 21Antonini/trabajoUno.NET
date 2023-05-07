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
    public void AgregarVehiculo(string[] datos)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{datos[0]},{datos[1]}");
        }
    }
    public void ModificarVehiculo(string[] datos)
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
            string[] vehiculoModificado = { datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (vehiculos[cont][0].Equals(datos[0]))
                {
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in vehiculos)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void EliminarVehiculo(string[] datos)
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
            string[] vehiculoModificado = { '*' + datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (vehiculos[cont][0].Equals(datos[0]))
                {
                    vehiculos[cont] = vehiculoModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in vehiculos)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void ListarVehiculos()
    {
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (!st[0].Contains("*"))
                {
                    Console.Write($"Nombre: {st[0]} | Apellido: {st[1]} \n");
                }
            }
        }
    }
}