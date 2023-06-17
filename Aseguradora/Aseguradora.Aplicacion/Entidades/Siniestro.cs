namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public int ID { get; set; } = -1;
    public string? idPoliza { get; set; }
    public string? idTercero { get; set; }
    public DateTime FechaCargaSistema { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string? DireccionDelHecho { get; set; } = "";
    public string? DescripcionDelHecho { get; set; } = "";

    public Siniestro(string poliza, string fechaIngreso, string fechaOcurrencia, string direccionDelHecho, string descripcionDelHecho, string tercero)
    {
        idPoliza = poliza;
        idTercero = tercero;
        FechaCargaSistema = DateTime.Parse(fechaIngreso);
        FechaOcurrencia = DateTime.Parse(fechaOcurrencia);
        DireccionDelHecho = direccionDelHecho;
        DescripcionDelHecho = descripcionDelHecho;
    }

}