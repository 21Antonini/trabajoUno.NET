namespace Aseguradora.Aplicacion;
public class Titular : Persona {
    public static int ID { get; set; } = 0;
    private int _id;
    public int id { get => _id; }
    private List<Vehiculo> _ListaVehiculos = new List<Vehiculo>();
    public List<Vehiculo> listaVehiculos { get => _ListaVehiculos; }
    private String? _Telefono;
    public String? Telefono { get => _Telefono; set => _Telefono = value;}
    private String? _Direccion;
    public String? Direccion { get => _Direccion; set => _Direccion = value; }
    private String? _Mail;
    public String? Mail { get => _Mail;set => _Mail = value; }

    public Titular(String _dni, String _nombre, String _apellido):base(_dni,_nombre,_apellido){
         _id = ID;
        ID++;
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
        String str = $"{_id}: ";
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