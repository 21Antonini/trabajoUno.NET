namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public List<Siniestro> listaSiniestro { get; set; } = new List<Siniestro>();
    public int ID { get; set; } = -1;
    public int VehiculoId { get; set; }
    public double valorAsegurado { get; set; }
    public string Franquicia { get; set; }
    public string Cobertura { get; set; }
    public DateTime VigenteDesde { get; set; }
    public DateTime VigenteHasta { get; set; }


    /*
    public Poliza( double valorAsegurado, string franquicia, string cobertura, DateTime vigenteDesde, DateTime vigenteHasta)
    {
        //en el constructor se debe agregar el IDVehiculoAsegurado
        //IDVehiculoAsegurado = idvehiculoAsegurado;
        this.valorAsegurado = valorAsegurado;
        Franquicia = franquicia;
        Cobertura = cobertura;
        VigenteDesde = vigenteDesde;
        VigenteHasta = vigenteHasta;
    }
    public override string ToString()
    {
        //aca traer de vuelta el "VehiculoAsegurado:{IDVehiculoAsegurado}"
        return $"{ID}:  ValorAsegurado:{this.valorAsegurado}" +
                $" Franquicia:{Franquicia} Cobertura:{Cobertura} VigenteDesde:{VigenteDesde:d}" +
                $" VigenteHasta:{VigenteHasta:d}";
    } 
    */
}