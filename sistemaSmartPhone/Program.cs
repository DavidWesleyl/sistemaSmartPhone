using sistemaSmartPhone;

internal class Program
{
	private static void Main(string[] args)
	{
        Console.WriteLine("SmartPhone => Nokia");
      
        
        SmartPhone nokia = new Nokia(numero: 40028922, modelo: "Lumia", imei: "123456789", memoria: 32);

        Console.WriteLine($"Seu número: {nokia.Numero}");
        Console.WriteLine();
        nokia.Ligar();
		nokia.instalarAplicativo("Instagram");


        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();

        Console.WriteLine("SmartPhone => Iphone");

        SmartPhone iphone = new Iphone(numero: 88776655, modelo: "10", imei: "282828", memoria: 64);

		Console.WriteLine($"Seu número: {iphone.Numero}");
		Console.WriteLine();
        iphone.receberLigacao();
        iphone.instalarAplicativo("Whatsapp");




	}
}