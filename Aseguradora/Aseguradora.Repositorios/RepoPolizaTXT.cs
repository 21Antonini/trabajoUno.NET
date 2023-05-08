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
}