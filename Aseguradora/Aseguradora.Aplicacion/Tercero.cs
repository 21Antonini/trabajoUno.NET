namespace Aseguradora.Aplicacion;
public class Tercero: Persona{
    private int ID {get;set;} = -1;
    private String? Telefono { set; get; }
    private String? Aseguradora { set; get; }
    private String? Siniestro { set; get; }
    public Tercero(String _dni, String _nombre, String _apellido):base(_dni,_nombre,_apellido){
        //PARA LA PRÓXIMA ENTREGA
    }
}