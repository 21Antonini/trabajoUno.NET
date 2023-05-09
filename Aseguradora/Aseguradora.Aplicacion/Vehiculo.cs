namespace Aseguradora.Aplicacion;
public class Vehiculo
{
    public static int ID { get; set; } = 0;
    private int _id;
    public int id { get => _id; }
    private String? _dominio;
    public String? Dominio { get => _dominio; }
    private String? _marca;
    public String? Marca { get => _marca; }
    private String? _fabricacion;
    public String? Fabricacion { get => _fabricacion; }
    private int _titular;
    public int idTitular { get => _titular; }

    public Vehiculo(String dom, String marca, String año, int id)
    {
        this._dominio = dom;
        this._fabricacion = año;
        this._marca = marca;
        this._titular = id;
        this._id = ID;
        ID++;
    }
    public override string ToString()
    {
        String st = $"ID: {_id}, Marca: {_marca}, Modelo: {_fabricacion}, Patente: {_dominio}, Titular: {_titular}";
        return st;
    }
}