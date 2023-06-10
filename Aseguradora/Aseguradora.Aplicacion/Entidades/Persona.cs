namespace Aseguradora.Aplicacion.Entidades;
public abstract class Persona
{
    public int ID { get; set; } = -1;
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public Persona(string dni, string nombre, string apellido)
    {
        Apellido = apellido;
        DNI = dni;
        Nombre = nombre;
    }
    public override string ToString()
    {
        string str = "";
        str += $"Nombre: {Nombre}, Apellido: {Apellido}, DNI: {DNI}";
        return str;
    }
}
