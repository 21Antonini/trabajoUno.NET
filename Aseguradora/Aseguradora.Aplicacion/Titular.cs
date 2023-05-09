namespace Aseguradora.Aplicacion;
public class Titular: Persona{
    private int ID {get;set;} = -1;
    private List<int> ListaVehiculos {get;set;} = new List<int>();
    private List<Vehiculo> ListaVehiculosInfo {get;set;} = new List<Vehiculo>();
    private String? _Telefono;
    private String? Telefono { get => _Telefono; }
    private String? _Direccion;
    public String? Direccion { get => _Direccion; }
    private String? _Mail;
    public String? Mail { get => _Mail; }

    public Titular(String _dni, String _nombre, String _apellido):base(_dni,_nombre,_apellido){
    }
    public Titular(String _dni, String _nombre, String _apellido,String Telefono,String Direccion,String Mail):base(_dni,_apellido,_nombre){
        _Mail=Mail;
        _Direccion=Direccion;
        _Telefono=Telefono;
    }

    public override string ToString()
    {
        String str = $"{ID}: ";
        str= str + base.ToString();
        if(_Telefono!=null)
            str+=$" Telefono:{_Telefono}";
        if(_Direccion!=null)
            str+=$" Direccion: {_Direccion}";
        if(_Mail!=null)
            str+=$" Mail: {_Mail}";
        if(ListaVehiculos.Count != 0){
            str+=" Vehiculos:";
            foreach(int i in ListaVehiculos){
                str+=$"{i},";
            }
        }
        return str;
    }
}