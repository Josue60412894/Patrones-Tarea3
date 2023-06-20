public interface IFabrica
{
    IVehiculo SeleccionarVehiculo(tipoVehiculo tipoVehiculo);
    
    IMotor SeleccionarMotor();

    //Metodo para correr pruebas despues de crear la clase 
    void Test();
    
}