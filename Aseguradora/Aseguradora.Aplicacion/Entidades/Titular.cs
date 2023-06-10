namespace Aseguradora.Aplicacion.Entidades;
public class Titular : Persona
{
    public List<Vehiculo> listaVehiculos { get; set; } = new List<Vehiculo>();
    public string? Telefono { get; set; }
    public string? Direccion { get; set; }
    public string? Mail { get; set ; }

    public Titular(string dni, string nombre, string apellido) : base(dni, nombre, apellido)
    {
    }
    public Titular(string dni, string nombre, string apellido, string Telefono, string Direccion, string Mail, List<Vehiculo> vehiculos = null) : base(dni, apellido, nombre)
    {
        Mail = Mail;
        Direccion = Direccion;
        Telefono = Telefono;
        listaVehiculos = vehiculos;
    }

    public override string ToString()
    {
        string str = $"{DNI}: ";
        str = str + base.ToString();
        if (Telefono != null)
            str += $" Telefono:{Telefono}";
        if (Direccion != null)
            str += $" Direccion: {Direccion}";
        if (Mail != null)
            str += $" Mail: {Mail}";
        if (listaVehiculos != null)
        {
            str += " Vehiculos:";
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                vehiculo.ToString();
            }
        }
        return str;
    }
}