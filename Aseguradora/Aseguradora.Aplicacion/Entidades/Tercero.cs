namespace Aseguradora.Aplicacion.Entidades;
public class Tercero : Persona
{
    public int ID { get; set; } = -1;
    public string? Telefono { set; get; }
    public string? Aseguradora { set; get; }
    public string? Siniestro { set; get; }
    public Tercero(string dni, string nombre, string apellido, string aseguradora, string telefono, string siniestro) : base(dni, nombre, apellido)
    {
        Telefono = telefono;
        Aseguradora = apellido;
        Siniestro = siniestro;
    }
}