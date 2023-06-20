using System;
class Program
{

//Programa donde se isntancian 2 Fabricas de carros. Electricos y de combusion.
//Luego se crean varios carros y se corren las pruebas
    static void Main(string[] args)
    {


        IFabrica EVfactory = new FabricaElectricos(); // creacion de la Fabrica de Vehiculos Electricos


        int i = 0;

        // se crean 4 Bicicletas electricas. El tipo se puede cambiar con el Enum tipoVehiculo
        //se corren las pruebas despues de crear el carro
        while (i < 5) 
        {
            EVfactory.SeleccionarVehiculo(tipoVehiculo.Bicicleta).CrearVehiculo();
            EVfactory.SeleccionarMotor().ObtenerMotor();
            EVfactory.Test();
            i++;
        }

        IFabrica Combustionfactory = new FabricaCombustion(); // creacion de la Fabrica de Vehiculos de Combustion

        // se crean 1 Motocicleta de combustion. El tipo se puede cambiar con el Enum tipoVehiculo
        //se corren las pruebas despues de crear el vehiculo
        Combustionfactory.SeleccionarVehiculo(tipoVehiculo.Motocicleta).CrearVehiculo();
        Combustionfactory.SeleccionarMotor().ObtenerMotor();
        Combustionfactory.Test();


    }

}

