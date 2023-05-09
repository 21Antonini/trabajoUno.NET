namespace Aseguradora.Aplicacion;
public class Titular : Persona {
    public static int ID { get; set; } = 0;
    private int _id = 0;
    private List<Vehiculo> _ListaVehiculos;
    public List<Vehiculo> listaVehiculos { get => _ListaVehiculos; }
    private String? _Telefono;
    public String? Telefono { get => _Telefono; }
    private String? _Direccion;
    public String? Direccion { get => _Direccion; }
    private String? _Mail;
    public String? Mail { get => _Mail; }

    public Titular(String _dni, String _nombre, String _apellido, List<Vehiculo> vehiculos):base(_dni,_nombre,_apellido){
        ID++;
        this._ListaVehiculos = vehiculos;
    }
    public Titular(String _dni, String _nombre, String _apellido,String Telefono,String Direccion,String Mail, List<Vehiculo> vehiculos) :base(_dni,_apellido,_nombre){
        _id = ID;
        _Mail=Mail;
        _Direccion=Direccion;
        _Telefono=Telefono;
        this._ListaVehiculos = vehiculos;
        ID++;
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
        if(_ListaVehiculos.Count != 0){
            str+=" Vehiculos:";
            foreach(Vehiculo vehiculo in _ListaVehiculos){
                vehiculo.ToString();
            }
        }
        return str;
    }
}