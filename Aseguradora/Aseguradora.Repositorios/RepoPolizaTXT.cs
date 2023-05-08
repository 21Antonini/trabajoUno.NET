/*using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoPolizaTXT : IRepoPoliza
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("polizas.txt");
    public void AgregarPoliza(string[] datos)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{datos[0]},{datos[1]}");
        }
    }
    public void ModificarPoliza(string[] datos)
    {
        List<string[]> polizas = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                polizas.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] polizaModificada = { datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (polizas[cont][0].Equals(datos[0]))
                {
                    polizas[cont] = polizaModificada;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in polizas)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void EliminarPoliza(string[] datos)
    {
        List<string[]> polizas = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                polizas.Add(sr.ReadLine().Split(','));
            }

        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] polizaModificada = { '*' + datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (polizas[cont][0].Equals(datos[0]))
                {
                    polizas[cont] = polizaModificada;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in polizas)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void ListarPolizas()
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
}*/