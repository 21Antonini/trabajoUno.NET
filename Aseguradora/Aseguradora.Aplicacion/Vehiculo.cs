namespace Aseguradora.Aplicacion;
public class Vehiculo{
    private String _dominio;
    private String _marca;
    private String _fabricacion;
    private int _dueño;

    public Vehiculo(String dom,String marca, String año, int id){
        this._dominio=dom;
        this._fabricacion=año;
        this._marca=marca;
        this._dueño=id;
    }
    public override string ToString()
    {
        String st= $"Marca: {_marca}, Modelo: {_fabricacion}, Patente: {_dominio}, Titular: {_dueño}";
        return st;
    }
}