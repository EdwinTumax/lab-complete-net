using CentralTelefonicaLab.Edu.Kinal.Lab.Entities;
using CentralTelefonicaLab.Edu.Kinal.Lab.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {        
        Llamada test = new LlamadaLocal();

        Llamada localUno = new LlamadaLocal("33124569","24711529",2);
        Llamada interiorUno = new LlamadaInterior("33124569","77451256",10,1);
        Llamada interiorDos = new LlamadaInterior("33124569","77451256",10,2);
        Llamada interiorTres = new LlamadaInterior("33124569","77451256",10,3);

        test.RegistrarLlamada(localUno);
        test.RegistrarLlamada(interiorUno);
        test.RegistrarLlamada(interiorDos);
        test.RegistrarLlamada(interiorTres);

        Console.WriteLine("Total llamadas: " + test.GetTotalLlamadas());
        Console.WriteLine("Total facturar: " + test.GetTotalFacturas());
        
        Console.ReadLine();

    }
}