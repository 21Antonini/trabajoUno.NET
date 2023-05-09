namespace Aseguradora.Aplicacion;
public class Vehiculo{
    private int ID {get;set;} = -1;
    private String? _dominio;
    public String? Dominio { get => _dominio; }
    private String? _marca;
    public String? Marca { get => _marca; }
    private String? _fabricacion;
    public String? Fabricacion { get => _fabricacion; }
    private int _dueño;
    public int Dueño { get => _dueño; }

    public Vehiculo(String dom,String marca, String año, int id){
        this._dominio=dom;
        this._fabricacion=año;
        this._marca=marca;
        this._dueño=id;
    }
    public override string ToString()
    {
        String st= $"ID: {ID}, Marca: {_marca}, Modelo: {_fabricacion}, Patente: {_dominio}, Titular: {_dueño}";
        return st;
    }
}