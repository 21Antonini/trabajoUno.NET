

//using Aseguradora.Repositorios;
//using Aseguradora.Aplicacion;
//using Aseguradora.Aplicacion.Entidades;
//using Microsoft.EntityFrameworkCore;

//using (var db = new AseguradoraContext())
//{
//    db.Database.EnsureCreated();
//}


//remover el comentario de esto
/*using (var db = new AseguradoraContext())
{
    /*Titular nuevo = new Titular()
    {
        Nombre = "shein",
        Apellido = "sito",
        DNI = "44522651",
        listaVehiculos = new List<Vehiculo>() {
        new Vehiculo(){Dominio="aaa111",Marca="Ford",Fabricacion="2018"}
        }
    };
    Titular nuev = new Titular()
    {
        Nombre = "ivan",
        Apellido = "trolo",
        DNI = "44522651",
        listaVehiculos = new List<Vehiculo>() {
        new Vehiculo(){Dominio="aaa111",Marca="Ford",Fabricacion="2018"}
        }
    };
    db.Add(nuevo);
    db.Add(nuev);
    db.SaveChanges();
    var alumnoBorrar = db.Titular.Where(a => a.ID == 1).SingleOrDefault();
    if (alumnoBorrar != null)
    {
        db.Remove(alumnoBorrar); //se borra realmente con el db.SaveChanges()
    }
    db.SaveChanges();




    var apellidoModificar = db.Titular.Where(
e => e.ID == 3).SingleOrDefault();
    if (apellidoModificar != null)
    {
        apellidoModificar.Apellido = "elmascapito"; //se modifica el registro en memoria
    }
    db.SaveChanges(); //actualiza la base de datos.

}*/





















//RepoTitularTXT repoTitular = new RepoTitularTXT();
//AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
////ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
////ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
//EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);

//Titular nuevo = new Titular()
//{
//    Nombre = "shein",
//    Apellido = "sito",
//    DNI = 55555555,
//    listaVehiculos = new List<Vehiculo>() {
//        new Vehiculo(){Dominio="aaa111",Marca="Ford",Fabricacion="2018"}
//        }
//};
//    repoTitular.AgregarTitular(nuevo);

/*using (var db = new AseguradoraContext())
{
    db.Add(nuevo);
    db.SaveChanges();
}*/




//Console.WriteLine($"Id del titular recién instanciado: {titular.ID}");

//Console.WriteLine(titular.ToString());
//repoTitular.AgregarTitular(new Titular("20654987", "Rodriguez", "Ana"));
//repoTitular.AgregarTitular(new Titular("31456444", "Alconada", "Fermín"));
//repoTitular.AgregarTitular(new Titular("12345654", "Perez", "Cecilia"));

//Console.WriteLine("Listando todos los titulares de vehículos");
//List<Titular> lista = new List<Titular>();
//lista = listarTitulares.Ejecutar();
//foreach (Titular t in lista)
//{
//Console.WriteLine(t);
//}




//Console.WriteLine("Eliminando al titular con id 2");
//eliminarTitular.Ejecutar(2);





//Console.WriteLine("Listando todos los titulares de vehículos");
//lista = listarTitulares.Ejecutar();
//foreach (Titular t in lista)
//{
//Console.WriteLine(t);
//}



//RepoVehiculoTXT repoVehiculo = new RepoVehiculoTXT();
//AgregarVehiculoUseCase agregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo);
//ListarVehiculosUseCase listarVehiculos = new ListarVehiculosUseCase(repoVehiculo);
//ModificarVehiculoUseCase modificarVehiculo = new ModificarVehiculoUseCase(repoVehiculo);
//EliminarVehiculoUseCase eliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo);

//Vehiculo V = new Vehiculo("abc123","ford","2012","1");
//repoVehiculo.AgregarVehiculo(V);

//repoVehiculo.AgregarVehiculo(new Vehiculo("abc126","ford","2012","1"));
//repoVehiculo.AgregarVehiculo(new Vehiculo("abc124","ford","2012","2"));
//repoVehiculo.AgregarVehiculo(new Vehiculo("abc125","ford","2012","3"));

//List<Vehiculo> listav = new List<Vehiculo>();

//Console.WriteLine("Listando todos los vehículos");
//listav = listarVehiculos.Ejecutar();
//foreach (Vehiculo v in listav)
//{
//Console.WriteLine(v);
//}

//Console.ReadKey();






//RepoPolizaTXT repoPoliza = new RepoPolizaTXT();
//AgregarPolizaUseCase agregarPoliza = new AgregarPolizaUseCase(repoPoliza);
//ListarPolizasUseCase listarPoliza = new ListarPolizasUseCase(repoPoliza);
//ModificarPolizaUseCase modificarPoliza = new ModificarPolizaUseCase(repoPoliza);
//EliminarPolizaUseCase eliminarPoliza = new EliminarPolizaUseCase(repoPoliza);

//Poliza P = new Poliza(0,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14));
//repoPoliza.AgregarPoliza(new Poliza(1,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
//repoPoliza.AgregarPoliza(new Poliza(2,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
//repoPoliza.AgregarPoliza(new Poliza(3,20000,"0","Todo Riesgo",new DateTime(2020,3,14),new DateTime(2024,3,14)));
//List<Poliza> listap = new List<Poliza>();

//Console.WriteLine("Listando todas las polizas");
//listap = listarPoliza.Ejecutar();
//foreach (Poliza p in listap)
//{
//Console.WriteLine(p);
//}

//Console.ReadKey();


//ListarTitularesConSusVehiculosUseCase listarTV = new ListarTitularesConSusVehiculosUseCase(repoTitular, repoVehiculo);
//List<Titular> titularV = new List<Titular>();
//titularV = listarTV.Ejecutar();

//foreach(Titular t in titularV)
//{
//    Console.WriteLine(t);
//}