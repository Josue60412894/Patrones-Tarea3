public class FabricaElectricos : IFabrica
{
    //Fabrica de Vehiculos Electricos. Crea el vehiculo seleccionado y le agregar el motor electrico
    public IVehiculo SeleccionarVehiculo(tipoVehiculo tipoVehiculo)
    {
        switch (tipoVehiculo)
        {
            case tipoVehiculo.Automovil:
                Console.WriteLine("\n+Se fabrica el siguiente vehiculo:");
                return new Automovil();

            case tipoVehiculo.Motocicleta:
                Console.WriteLine("\n+Se fabrica el siguiente vehiculo:");
                return new Motocicleta();

            case tipoVehiculo.Bicicleta:
                Console.WriteLine("\n+Se fabrica el siguiente vehiculo:");
                return new Bicicleta();

            default:
                throw new Exception("Opcion invalida");
        }
    }


    public IMotor SeleccionarMotor()
    {
                Console.WriteLine("El cual tiene el siguiente motor:");
                return new Electrico();
    }


    public void Test(){

        var Prueba = Test_System.GetInstance();
        Prueba.PruebaAceleracion();
        Prueba.PruebaAvance();
        Prueba.PruebaFrenado();
        Prueba.PruebaRetroceso();

    

        if(Prueba.GetInstanceCount() > 4){
         Prueba.CrearLogFile();
        }

    }


    
}