/*using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoTerceroTXT : IRepoTercero
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("terceros.txt");
    public void AgregarTercero(string[] datos)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{datos[0]},{datos[1]}");
        }
    }
    public void ModificarTercero(string[] datos)
    {
        List<string[]> terceros = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                terceros.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] terceroModificado = { datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (terceros[cont][0].Equals(datos[0]))
                {
                    terceros[cont] = terceroModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in terceros)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void EliminarTercero(string[] datos)
    {
        List<string[]> terceros = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                terceros.Add(sr.ReadLine().Split(','));
            }

        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] terceroModificado = { '*' + datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (terceros[cont][0].Equals(datos[0]))
                {
                    terceros[cont] = terceroModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in terceros)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void ListarTerceros()
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