namespace Aseguradora.Aplicacion;
public class Poliza{
    private int ID {get;set;} = -1;
    private int IDVehiculoAsegurado {get;set;}
    private double ValorAsegurado {get;set;}
    private string Franquicia {get; set;}
    private string Cobertura {get; set;}
    private DateTime VigenteDesde {get; set;}
    private DateTime VigenteHasta {get; set;}
    public Poliza(int idvehiculoAsegurado, double valorAsegurado, string franquicia, string cobertura, DateTime vigenteDesde, DateTime vigenteHasta)
    {
        ID++;
        IDVehiculoAsegurado = idvehiculoAsegurado;
        ValorAsegurado = valorAsegurado;
        Franquicia = franquicia;
        Cobertura = cobertura;
        VigenteDesde = vigenteDesde;
        VigenteHasta = vigenteHasta;
    }
    public override string ToString()
    {
        return  $"{ID}: VehiculoAsegurado:{IDVehiculoAsegurado} ValorAsegurado:{ValorAsegurado}"+
                $" Franquicia:{Franquicia} Cobertura:{Cobertura} VigenteDesde:{VigenteDesde:d}"+
                $" VigenteHasta:{VigenteHasta:d}";
    }
}