using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseguradora.Repositorios
{
    public class RepoTercero: IRepoTercero
    {
        static private string? _obtenerPath(string archivo)
        {
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            return directory.Parent.Parent.Parent.FullName + "\\" + "datos" + "\\" + archivo;
        }

        private string? _path = _obtenerPath("terceros.txt");
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
                return ids[4];
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
                int aux = Int32.Parse(ids[4]);
                aux++;
                sw.WriteLine($"{ids[0]},{ids[1]},{ids[2]},{ids[3]},{aux}");
            }
        }

        public void AgregarTercero(Tercero tercero)
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                List<string[]> terceroes = new List<string[]>();
                while (!sr.EndOfStream)
                {
                    terceroes.Add(sr.ReadLine().Split(','));
                }

                foreach (string[] st in terceroes)
                {
                    if (st[1].Equals(tercero.DNI))
                    {
                        throw new Exception("El tercero ingresado ya existe.");
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                sw.WriteLine($"{determinarID()},{tercero.DNI},{tercero.Nombre},{tercero.Apellido},{tercero.Aseguradora},{tercero.Telefono},{tercero.Siniestro}");
                actualizarID();
            }
        }
        public void ModificarTercero(Tercero tercero)
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
                string[] terceroModificado = { "0", tercero.DNI, tercero.Nombre, tercero.Apellido, tercero.Aseguradora, tercero.Telefono, tercero.Siniestro };
                Boolean encontre = false;
                int cont = 0;
                while (!encontre && cont < terceros.Count)
                {
                    if (terceros[cont][1].Equals(tercero.DNI))
                    {
                        terceroModificado[0] = terceros[cont][0];
                        terceros[cont] = terceroModificado;
                        encontre = true;
                    }
                    cont++;
                }

                if (!encontre)
                {
                    throw new Exception("El DNI ingresado no corresponde a ningun tercero registrado.");
                }
                else
                {
                    foreach (string[] st in terceros)
                    {
                        sw.WriteLine(string.Join(",", st));
                    }
                }
            }
        }
        public void EliminarTercero(int idTercero)
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
                Boolean encontre = false;
                int cont = 0;
                while (!encontre && cont < terceros.Count)
                {
                    if (terceros[cont][0].Equals(idTercero.ToString()))
                    {
                        string[] terceroModificado = terceros[cont];
                        terceroModificado[0] = "*" + terceroModificado[0];
                        terceros[cont] = terceroModificado;
                        encontre = true;
                    }
                    cont++;
                }

                if (!encontre)
                {
                    throw new Exception("El ID ingresado no corresponde a ningun tercero registrado.");
                }
                else
                {
                    foreach (string[] st in terceros)
                    {
                        sw.WriteLine(string.Join(",", st));
                    }
                }
            }
        }
        public List<Tercero> ListarTerceros()
        {
            List<Tercero> resultado = new List<Tercero>();
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
                            st[4] aseguradora
                            st[5] telefono
                            st[6] siniestro
                         */
                        Tercero newTercero = new Tercero(st[1], st[2], st[3], st[4], st[5], st[6]);
                        newTercero.ID = Int32.Parse(st[0]);
                        resultado.Add(newTercero);
                    }
                }
            }
            return resultado;
        }
    }
}
