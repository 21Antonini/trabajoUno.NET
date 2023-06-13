using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Repositorios;
public class RepoPolizaTXT : IRepoPoliza
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("polizas.txt");
    private string? _idsPath = _obtenerPath("persistenciaIDs.txt");
    public string determinarID()
    {
        using (StreamReader sr = new StreamReader(_idsPath))
        {
            string?[] ids = new string[4];
            //ids llevara un conteo de la cantidad de ids creada por cada entidad
            //ids[0] titulares
            //ids[1] polizas
            //ids[2] vehiculos
            //ids[3] siniestros
            //ids[4] terceros
            ids = sr.ReadLine().Split(',');
            return ids[1];
        }
    }
    public void actualizarID()
    {
        string?[] ids = new string[4];
        using (StreamReader sr = new StreamReader(_idsPath))
        {
            //ids llevara un conteo de la cantidad de ids creada por cada entidad
            //ids[0] titulares
            //ids[1] polizas
            //ids[2] vehiculos
            //ids[3] siniestros
            //ids[4] terceros
            ids = sr.ReadLine().Split(',');
        }
        using (StreamWriter sw = new StreamWriter(_idsPath, false))
        {
            int aux = Int32.Parse(ids[1]);
            aux++;
            sw.WriteLine($"{ids[0]},{aux},{ids[2]},{ids[3]},{ids[4]}");
        }
    }
    public void AgregarPoliza(Poliza poliza)
    {
        using (StreamReader sr = new StreamReader(_path))
        {
            List<string[]> polizas = new List<string[]>();
            while (!sr.EndOfStream)
            {
                polizas.Add(sr.ReadLine().Split(','));
            }

            foreach (string[] st in polizas)
            {
                if (st[1].Equals(poliza.IDVehiculoAsegurado))
                {
                    throw new Exception("La poliza ingresada ya existe.");
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{determinarID},{poliza.IDVehiculoAsegurado},{poliza.Cobertura},{poliza.Franquicia},{poliza.valorAsegurado},{poliza.VigenteDesde.ToString("dd/MM/yyyy")},{poliza.VigenteHasta.ToString("dd/MM/yyyy")}");
            actualizarID();
        }
    }
    public void ModificarPoliza(Poliza poliza)
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
            string[] polizaModificado = { poliza.ID.ToString(), poliza.IDVehiculoAsegurado.ToString(), poliza.Cobertura, poliza.Franquicia,poliza.valorAsegurado.ToString(), poliza.VigenteDesde.ToString("dd/MM/yyyy"), poliza.VigenteHasta.ToString("dd/MM/yyyy") };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < polizas.Count)
            {
                if (polizas[cont][0].Equals(poliza.ID))
                {
                    polizas[cont] = polizaModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("La poliza ingresada no corresponde a ningun poliza registrada.");
            }
            else
            {
                foreach (string[] st in polizas)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public void EliminarPoliza(int idPoliza)
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
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < polizas.Count)
            {
                if (polizas[cont][0].Equals(idPoliza))
                {
                    string[] polizaModificado = polizas[cont];
                    polizaModificado[0] = "*" + polizaModificado[0];
                    polizas[cont] = polizaModificado;
                    encontre = true;
                }
                cont++;
            }

            if (!encontre)
            {
                throw new Exception("El ID ingresado no corresponde a ningun poliza registrado.");
            }
            else
            {
                foreach (string[] st in polizas)
                {
                    sw.WriteLine(string.Join(",", st));
                }
            }
        }
    }
    public List<Poliza> ListarPolizas()
    {
        List<Poliza> resultado = new List<Poliza>();
        using (StreamReader sr = new StreamReader(_path))
        {

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (!st[0].Contains("*"))
                {
                    /*
                        st[0] id
                        st[1] idVehiculoAsegurado
                        st[2] Cobertura
                        st[3] Franquicia
                        st[4] valorAsegurado
                        st[5] vigenteDesde
                        st[6] vigenteHasta
                     */
                    Poliza newPoliza = new Poliza(Int32.Parse(st[1]), Double.Parse(st[4]),st[3],st[2],DateTime.Parse(st[5]),DateTime.Parse(st[6]));
                    newPoliza.ID = Int32.Parse(st[0]);
                    resultado.Add(newPoliza);
                }
            }
        }
        return resultado;
    }
}