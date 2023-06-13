using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseguradora.Repositorios
{
    public class RepoSiniestroTXT: IRepoSiniestro
    {
        static private string? _obtenerPath(string archivo)
        {
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
        }

        private string? _path = _obtenerPath("siniestros.txt");
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
                return ids[3];
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
                int aux = Int32.Parse(ids[3]);
                aux++;
                sw.WriteLine($"{ids[0]},{ids[1]},{ids[2]},{aux},{ids[4]}");
            }
        }
        public void AgregarSiniestro(Siniestro siniestro)
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                List<string[]> siniestros = new List<string[]>();
                while (!sr.EndOfStream)
                {
                    siniestros.Add(sr.ReadLine().Split(','));
                }

                foreach (string[] st in siniestros)
                {
                    if (st[1].Equals(siniestro.ID))
                    {
                        throw new Exception("El siniestro ingresado ya existe.");
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine($"{determinarID},{siniestro.Poliza},{siniestro.FechaCargaSistema},{siniestro.FechaOcurrencia},{siniestro.DireccionDelHecho},{siniestro.DescripcionDelHecho}");
                actualizarID();
            }
        }
        public void ModificarSiniestro(Siniestro siniestro)
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
                string[] siniestroModificado = { siniestro.ID.ToString(), siniestro.Poliza, siniestro.FechaCargaSistema.ToString(), siniestro.FechaOcurrencia.ToString(), siniestro.DireccionDelHecho, siniestro.DescripcionDelHecho };
                Boolean encontre = false;
                int cont = 0;
                while (!encontre && cont < siniestros.Count)
                {
                    if (siniestros[cont][0].Equals(siniestro.ID))
                    {
                        siniestros[cont] = siniestroModificado;
                        encontre = true;
                    }
                    cont++;
                }

                if (!encontre)
                {
                    throw new Exception("El siniestro ingresado no corresponde a ningun siniestro registrado.");
                }
                else
                {
                    foreach (string[] st in siniestros)
                    {
                        sw.WriteLine(string.Join(",", st));
                    }
                }
            }
        }
        public void EliminarSiniestro(int idSiniestro)
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
                Boolean encontre = false;
                int cont = 0;
                while (!encontre && cont < siniestros.Count)
                {
                    if (siniestros[cont][0].Equals(idSiniestro))
                    {
                        string[] siniestroModificado = siniestros[cont];
                        siniestroModificado[0] = "*" + siniestroModificado[0];
                        siniestros[cont] = siniestroModificado;
                        encontre = true;
                    }
                    cont++;
                }

                if (!encontre)
                {
                    throw new Exception("El siniestro ingresado no corresponde a ningun siniestro registrado.");
                }
                else
                {
                    foreach (string[] st in siniestros)
                    {
                        sw.WriteLine(string.Join(",", st));
                    }
                }
            }
        }
        public List<Siniestro> ListarSiniestros()
        {
            List<Siniestro> resultado = new List<Siniestro>();
            using (StreamReader sr = new StreamReader(_path))
            {

                while (!sr.EndOfStream)
                {
                    string[] st = sr.ReadLine().Split(',');
                    if (!st[0].Contains("*"))
                    {
                        /*
                            st[0] id
                            st[1] polizaId
                            st[2] fechaIngresoSistema
                            st[3] fechaOcurrencia
                            st[4] direccionDelHecho
                            st[5] descripcionDelHecho
                         */
                        Siniestro newSiniestro = new Siniestro(st[1], st[2], st[3], st[4], st[5]);
                        newSiniestro.ID = Int32.Parse(st[0]);
                        resultado.Add(newSiniestro);
                    }
                }
            }
            return resultado;
        }
    }
}
