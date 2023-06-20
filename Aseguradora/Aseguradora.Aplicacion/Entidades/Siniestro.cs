namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public List<Tercero> listaTercero { get; set; } = new List<Tercero>();
    public int ID { get; set; }
    public int PolizaId { get; set; }
    public DateTime FechaCargaSistema { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string? DireccionDelHecho { get; set; } = "";
    public string? DescripcionDelHecho { get; set; } = "";

    //public Siniestro(string idPoliza, string FechaCargaSistema, string FechaOcurrencia, string direccionDelHecho, string descripcionDelHecho, string idTercero)
    //{
    //    this.idPoliza = idPoliza;
    //    this.idTercero = idTercero;
    //    this.FechaCargaSistema = DateTime.Parse(FechaCargaSistema);
    //    this.FechaOcurrencia = DateTime.Parse(FechaOcurrencia);
    //    DireccionDelHecho = direccionDelHecho;
    //    DescripcionDelHecho = descripcionDelHecho;
    //}

}