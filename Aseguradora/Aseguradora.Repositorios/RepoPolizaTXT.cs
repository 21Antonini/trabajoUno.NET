using Aseguradora.Aplicacion;

namespace Aseguradora.Repositorios;
public class RepoPolizaTXT : IRepoPoliza
{
    static private string? _obtenerPath(string archivo)
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
        return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
    }

    private string? _path = _obtenerPath("polizas.txt");
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
                if (st[0].Equals(poliza.id))
                {
                    throw new Exception("La poliza ingresada ya existe.");
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(_path, true))
        {
            sw.WriteLine($"{poliza.id},{poliza.IDVehiculoAsegurado},{poliza.Cobertura},{poliza.Franquicia},{poliza.valorAsegurado},{poliza.VigenteDesde.ToString("dd/MM/yyyy")},{poliza.VigenteHasta.ToString("dd/MM/yyyy")}");
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
            string[] polizaModificado = { poliza.id.ToString(), poliza.IDVehiculoAsegurado.ToString(), poliza.Cobertura, poliza.Franquicia,poliza.valorAsegurado.ToString(), poliza.VigenteDesde.ToString("dd/MM/yyyy"), poliza.VigenteHasta.ToString("dd/MM/yyyy") };
            Boolean encontre = false;
            int cont = 0;
            while (!encontre && cont < polizas.Count)
            {
                if (polizas[cont][0].Equals(poliza.id))
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
        Poliza.ID = 0;
        using (StreamReader sr = new StreamReader(_path))
        {

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(',');
                if (st[0].Contains("*"))
                {
                    Poliza.ID++;
                }
                else
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
                    resultado.Add(newPoliza);
                }
            }
        }
        return resultado;
    }
}