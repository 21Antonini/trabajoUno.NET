namespace Aseguradora.Aplicacion;
public abstract class Persona{
    protected static int contTitular=0;
    protected static int contTercero=0;
    protected int _id{get;set;}
    protected String _dni {get; set;}
    protected String _nombre{get; set;}
    protected String _apellido{get; set;}

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
