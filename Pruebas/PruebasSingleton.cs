
//Singleton Class
public sealed class Test_System
{
  
    private Test_System() { }

    private int InstanceCount;

    private static Test_System _instance = null;
    
    public static Test_System GetInstance() //metodo para llamar Singleton class
    {
        if (_instance == null)
        {
           // instancecount = 0;
            _instance = new Test_System();
        }
        return _instance;
    }

    //Metodos de Test de vehiculos
    public void PruebaAvance()
    {
        Console.WriteLine("\n*Prueba de avance es exitosa");
    }

    //Metodos de Test de vehiculos
    public void PruebaFrenado()
    {
        Console.WriteLine("*Prueba de frenado es exitosa");
    }

    //Metodos de Test de vehiculos
    public void PruebaAceleracion()
    {
        Console.WriteLine("*Prueba de aceleracion es exitosa");
    }

    //Metodos de Test de vehiculos
    public void PruebaRetroceso()
    {
        Console.WriteLine("*Prueba de retroceso es exitosa\n");
        Console.WriteLine("\n***********************************");
        InstanceCount++; //incrementa la cuenta de testing
        Console.WriteLine(InstanceCount);
    }

    //Metodo para sacar el conteo de pruebas consecutivas
    public int GetInstanceCount()
    {
        return InstanceCount; 
    }

    //Metodo para loguear arhivos de pruebas
    public void CrearLogFile(){
        string fileName = $"pruebas_{DateTime.Now:yyyy-MM-dd}_{DateTime.Now:HHmmss}.txt"; // Generate the file name with current date
        string filePath = Path.Combine(Environment.CurrentDirectory, fileName); // Combine file name with current directory

        // Create and write content to the text file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Archivo de registro!");
            writer.WriteLine("Se han corrido 5 pruebas");
        }

        Console.WriteLine("Text file created successfully.");

        InstanceCount = 0; //reinicia el conteo de pruebas
    }
}