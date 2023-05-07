using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoTitularTXT : IRepoTitular
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("titulares.txt");
    public void AgregarTitular(string[] datos)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{datos[0]},{datos[1]}");
        }
    }
    public void ModificarTitular(string[] datos)
    {
        List<string[]> titulares = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                titulares.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] titularModificado = { datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (titulares[cont][0].Equals(datos[0]))
                {
                    titulares[cont] = titularModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in titulares)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void EliminarTitular(string[] datos)
    {
        List<string[]> titulares = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                titulares.Add(sr.ReadLine().Split(','));
            }

        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] titularModificado = { '*'+datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (titulares[cont][0].Equals(datos[0]))
                {
                    titulares[cont] = titularModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in titulares)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void ListarTitulares()
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
