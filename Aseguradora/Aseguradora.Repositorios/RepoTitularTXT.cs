﻿/*using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoTitularTXT : IRepoTitular
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("titulares.txt");
    public void AgregarTitular(Titular titular)
    {
        using (StreamReader sr = new StreamReader(_path))
        {
            List<string[]> titulares = new List<string[]>();
            while (!sr.EndOfStream)
            {
                titulares.Add(sr.ReadLine().Split(','));
            }

            foreach (string[] st in titulares)
            {
                if (st[0].Equals(titular.DNI))
                {
                    throw new Exception("El titular ingresado ya existe.");
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{titular.id},{titular.DNI},{titular.Nombre},{titular.Apellido},{titular.Mail},{titular.Telefono},{titular.Direccion}");
        }
    }
    public void ModificarTitular(Titular titular)
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
            string[] titularModificado = { titular.id.ToString(), titular.DNI,titular.Nombre,titular.Apellido,titular.Mail,titular.Telefono,titular.Direccion};
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < titulares.Count)
            {
                if (titulares[cont][1].Equals(titular.DNI))
                {
                    titulares[cont] = titularModificado;
                    encontre = true;
                }
                cont++;
            }

            if(!encontre)
            {
                throw new Exception("El DNI ingresado no corresponde a ningun titular registrado.");
            }
            else
            {
                foreach (string[] st in titulares)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public void EliminarTitular(int idTitular)
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
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < titulares.Count)
            {
                if (titulares[cont][0].Equals(idTitular))
                {
                    string[] titularModificado = titulares[cont];
                    titularModificado[0] = "*" + titularModificado[1];
                    titulares[cont] = titularModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El ID ingresado no corresponde a ningun titular registrado.");
            }
            else
            {
                foreach (string[] st in titulares)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public List<Titular> ListarTitulares()
    {
        List<Titular> resultado = new List<Titular> ();
        using (StreamReader sr = new StreamReader(_path))
        {
            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (!st[0].Contains("*"))
                {
                    /*
                        st[0] id 
                        st[1] dni
                        st[2] nombre
                        st[3] apellido
                        st[4] mail
                        st[5] telefono
                        st[6] direccion
                     */
                    Titular newTitular = new Titular(st[1], st[2], st[3], st[5], st[6], st[4]);
                    resultado.Add(newTitular);
                }
            }
        }
        return resultado;
    }
}
*/