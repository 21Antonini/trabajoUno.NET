namespace Aseguradora.Aplicacion.Entidades;
public class Tercero : Persona
{
    public int ID { get; set; } = -1;
    public string? Telefono { set; get; }
    public string? Aseguradora { set; get; }
    public string? Siniestro { set; get; }
    public Tercero(string _dni, string _nombre, string _apellido) : base(_dni, _nombre, _apellido)
    {
        //PARA LA PRÓXIMA ENTREGA
    }
}