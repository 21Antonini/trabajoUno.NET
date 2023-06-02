namespace Aseguradora.Aplicacion.Entidades;
public class Vehiculo
{
    public int ID { get; set; } = -1;
    public string? Dominio { get; set; }
    public string? Marca { get; set; }
    public string? Fabricacion { get; set; }
    public int idTitular { get; set; }

    public Vehiculo(string dom, string marca, string año, string idTitular)
    {
        Dominio = dom;
        Fabricacion = año;
        Marca = marca;
        this.idTitular = Int32.Parse(idTitular);
    }
    public override string ToString()
    {
        string st = $"ID: {ID}, Marca: {Marca}, Modelo: {Fabricacion}, Patente: {Dominio}, Titular: {idTitular}";
        return st;
    }
}