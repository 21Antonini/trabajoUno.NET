/*using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoSiniestroTXT : IRepoSiniestro
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("siniestros.txt");
    public void AgregarSiniestro(string[] datos)
    {
        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{datos[0]},{datos[1]}");
        }
    }
    public void ModificarSiniestro(string[] datos)
    {
        List<string[]> siniestros = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                siniestros.Add(sr.ReadLine().Split(','));
            }
        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] siniestroModificado = { datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (siniestros[cont][0].Equals(datos[0]))
                {
                    siniestros[cont] = siniestroModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in siniestros)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void EliminarSiniestro(string[] datos)
    {
        List<string[]> siniestros = new List<string[]>();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                siniestros.Add(sr.ReadLine().Split(','));
            }

        }
        using (StreamWriter sw = new StreamWriter(_path))
        {
            string[] siniestroModificado = { '*' + datos[0], datos[1] };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre)
            {
                if (siniestros[cont][0].Equals(datos[0]))
                {
                    siniestros[cont] = siniestroModificado;
                    encontre = true;
                }
                cont++;
            }

            foreach (string[] st in siniestros)
            {
                sw.WriteLine(string.Join(",", st));
            }
        }
    }
    public void ListarSiniestros()
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