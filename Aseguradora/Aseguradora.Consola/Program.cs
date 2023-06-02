using Aseguradora.Repositorios;
using Aseguradora.Aplicacion;
using Aseguradora.Aplicacion.Entidades;

RepoTitularTXT repoTitular = new RepoTitularTXT();
AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);

Titular titular = new Titular("33123456", "García", "Juan")
{
Direccion = "13 nro. 546",
Telefono = "221-456456",
Mail = "joseGarcia@gmail.com"
};
Console.WriteLine($"Id del titular recién instanciado: {titular.id}");

repoTitular.AgregarTitular(titular);

Console.WriteLine(titular.ToString());
repoTitular.AgregarTitular(new Titular("20654987", "Rodriguez", "Ana"));
repoTitular.AgregarTitular(new Titular("31456444", "Alconada", "Fermín"));
repoTitular.AgregarTitular(new Titular("12345654", "Perez", "Cecilia"));

Console.WriteLine("Listando todos los titulares de vehículos");
List<Titular> lista = new List<Titular>();
lista = listarTitulares.Ejecutar();
foreach (Titular t in lista)
{
Console.WriteLine(t);
}

//Console.WriteLine("Eliminando al titular con id 1");
//eliminarTitular.Ejecutar(1);


Console.WriteLine("Listando todos los titulares de vehículos");
lista = listarTitulares.Ejecutar();
foreach (Titular t in lista)
{
Console.WriteLine(t);
}



RepoVehiculoTXT repoVehiculo = new RepoVehiculoTXT();
AgregarVehiculoUseCase agregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo);
ListarVehiculosUseCase listarVehiculos = new ListarVehiculosUseCase(repoVehiculo);
ModificarVehiculoUseCase modificarVehiculo = new ModificarVehiculoUseCase(repoVehiculo);
EliminarVehiculoUseCase eliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo);

Vehiculo V = new Vehiculo("abc123","ford","2012",1);
repoVehiculo.AgregarVehiculo(V);

repoVehiculo.AgregarVehiculo(new Vehiculo("abc123","ford","2012",1));
repoVehiculo.AgregarVehiculo(new Vehiculo("abc123","ford","2012",2));
repoVehiculo.AgregarVehiculo(new Vehiculo("abc123","ford","2012",3));

List<Vehiculo> listav = new List<Vehiculo>();

Console.WriteLine("Listando todos los vehículos");
listav = listarVehiculos.Ejecutar();
foreach (Vehiculo v in listav)
{
Console.WriteLine(v);
}

Console.ReadKey();






RepoPolizaTXT repoPoliza = new RepoPolizaTXT();
AgregarPolizaUseCase agregarPoliza = new AgregarPolizaUseCase(repoPoliza);
ListarPolizasUseCase listarPoliza = new ListarPolizasUseCase(repoPoliza);
ModificarPolizaUseCase modificarPoliza = new ModificarPolizaUseCase(repoPoliza);
EliminarPolizaUseCase eliminarPoliza = new EliminarPolizaUseCase(repoPoliza);

Poliza P = new Poliza(0,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14));
repoPoliza.AgregarPoliza(new Poliza(1,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
repoPoliza.AgregarPoliza(new Poliza(2,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
repoPoliza.AgregarPoliza(new Poliza(3,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
List<Poliza> listap = new List<Poliza>();

Console.WriteLine("Listando todas las polizas");
listap = listarPoliza.Ejecutar();
foreach (Poliza p in listap)
{
Console.WriteLine(p);
}

Console.ReadKey();
