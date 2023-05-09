namespace Aseguradora.Aplicacion;
public class Poliza {
    public static int ID { get; set; } = 0;
    private int _id;
    public int id { get => _id; }
    private int _IDVehiculoAsegurado;
    public int IDVehiculoAsegurado { get => _IDVehiculoAsegurado; }
    private double _ValorAsegurado;
    public double valorAsegurado { get => _ValorAsegurado; }
    private string _Franquicia {get; set;}
    public string Franquicia { get => _Franquicia; }
    private string _Cobertura {get; set;}
    public string Cobertura { get => _Cobertura; }
    private DateTime _VigenteDesde {get; set;}
    public DateTime VigenteDesde { get => _VigenteDesde; }
    private DateTime _VigenteHasta {get; set;}
    public DateTime VigenteHasta { get => _VigenteHasta; }
    public Poliza(int idvehiculoAsegurado, double valorAsegurado, string franquicia, string cobertura, DateTime vigenteDesde, DateTime vigenteHasta)
    {
        _IDVehiculoAsegurado = idvehiculoAsegurado;
        _ValorAsegurado = valorAsegurado;
        _Franquicia = franquicia;
        _Cobertura = cobertura;
        _VigenteDesde = vigenteDesde;
        _VigenteHasta = vigenteHasta;
        _id = ID;
        ID++;
    }
    public override string ToString()
    {
        return  $"{ID}: VehiculoAsegurado:{_IDVehiculoAsegurado} ValorAsegurado:{_ValorAsegurado}"+
                $" Franquicia:{_Franquicia} Cobertura:{_Cobertura} VigenteDesde:{_VigenteDesde:d}"+
                $" VigenteHasta:{_VigenteHasta:d}";
    }
}