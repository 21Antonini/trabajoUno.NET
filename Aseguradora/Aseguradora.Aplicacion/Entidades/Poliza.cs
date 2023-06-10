namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int ID { get; set; } = -1;
    public int IDVehiculoAsegurado { get; set; }
    public double valorAsegurado { get; set; }
    public string Franquicia { get; set; }
    public string Cobertura { get; set; }
    public DateTime VigenteDesde { get; set; }
    public DateTime VigenteHasta { get; set; }
    public Poliza(int idvehiculoAsegurado, double valorAsegurado, string franquicia, string cobertura, DateTime vigenteDesde, DateTime vigenteHasta)
    {
        IDVehiculoAsegurado = idvehiculoAsegurado;
        this.valorAsegurado = valorAsegurado;
        Franquicia = franquicia;
        Cobertura = cobertura;
        VigenteDesde = vigenteDesde;
        VigenteHasta = vigenteHasta;
    }
    public override string ToString()
    {
        return $"{ID}: VehiculoAsegurado:{IDVehiculoAsegurado} ValorAsegurado:{this.valorAsegurado}" +
                $" Franquicia:{Franquicia} Cobertura:{Cobertura} VigenteDesde:{VigenteDesde:d}" +
                $" VigenteHasta:{VigenteHasta:d}";
    }
}