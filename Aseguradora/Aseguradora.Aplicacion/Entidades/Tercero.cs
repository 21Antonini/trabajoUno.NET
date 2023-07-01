namespace Aseguradora.Aplicacion.Entidades;
public class Tercero : Persona
{
    //public int ID { get; set; }
    public string? Telefono { set; get; }
    public string? Aseguradora { set; get; }
    public int SiniestroID { set; get; }
    //public Tercero(string dni, string nombre, string apellido) : base(dni, nombre, apellido)
    //{
    //}
    //public Tercero(string dni, string nombre, string apellido, string aseguradora, string telefono, string siniestro) : base(dni, nombre, apellido)
    //{
    //    Telefono = telefono;
    //    Aseguradora = apellido;
    //    Siniestro = siniestro;
    //}
}