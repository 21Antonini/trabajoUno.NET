using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System.ComponentModel;

namespace Aseguradora.Repositorios;
public class RepoTitularTXT : IRepoTitular
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("titulares.txt");
    private string? _idsPath = _obtenerPath("persistenciaIDs.txt");
    public string determinarID()
    {
        using (StreamReader sr = new StreamReader(_idsPath))
        {
            string?[] ids = new string[3];
            //ids llevara un conteo de la cantidad de ids creada por cada entidad
            //ids[0] titulares
            //ids[1] polizas
            //ids[2] vehiculos
            ids = sr.ReadLine().Split(',');
            return ids[0];
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
        using (StreamWriter sw = new StreamWriter(_idsPath, false))
        {
            int aux = Int32.Parse(ids[0]);
            aux++;
            sw.WriteLine($"{aux},{ids[1]},{ids[2]}");
        }
    }

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
                if (st[1].Equals(titular.DNI))
                {
                    throw new Exception("El titular ingresado ya existe.");
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{determinarID()},{titular.DNI},{titular.Nombre},{titular.Apellido},{titular.Mail},{titular.Telefono},{titular.Direccion}");
            actualizarID();
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
            string[] titularModificado = { "0", titular.DNI,titular.Nombre,titular.Apellido,titular.Mail,titular.Telefono,titular.Direccion};
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < titulares.Count)
            {
                if (titulares[cont][1].Equals(titular.DNI))
                {
                    titularModificado[0] = titulares[cont][0];
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
                if (titulares[cont][0].Equals(idTitular.ToString()))
                {
                    string[] titularModificado = titulares[cont];
                    titularModificado[0] = "*" + titularModificado[0];
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
                    newTitular.ID = Int32.Parse(st[0]);
                    resultado.Add(newTitular);
                }
            }
        }
        return resultado;
    }

    public List<Titular> ListarTitularesConVehiculos(List<Vehiculo> vehiculos)
    {
        List<Titular> titularesConVehiculos = new List<Titular>();
        List<Titular> titulares = ListarTitulares();
        foreach(Titular titular in titulares)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.idTitular == titular.ID)
                {
                    titular.listaVehiculos.Add(vehiculo);
                }
            }
            titularesConVehiculos.Add(titular);
        }
        return titularesConVehiculos;
    }

   
}