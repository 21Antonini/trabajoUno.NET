namespace Aseguradora.Aplicacion;
public abstract class Persona{
    protected String _dni;
    public String DNI { get => _dni; }
    protected String _nombre;
    public String Nombre { get => _nombre; }
    protected String _apellido;
    public String Apellido { get => _apellido; }

    public Persona(String dni,String nombre,String apellido){
        this._apellido=apellido;
        this._dni=dni;
        this._nombre=nombre;
    }
    public override string ToString()
    {
        String str="";
        str+= $"Nombre: {this._nombre}, Apellido: {this._apellido}, DNI: {this._dni}";
        return str;
    }
}
