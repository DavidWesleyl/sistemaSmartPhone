using System;

namespace sistemaSmartPhone
{
	internal class Iphone : SmartPhone // Classe "Filha" Iphone, herda de SmartPhone todas as funções
	{
		public Iphone(int numero, string modelo, string imei, int memoria) 
			: base(numero, modelo, imei, memoria)
		{
			

		}

		public override void instalarAplicativo(string nomeApp)
		{
            Console.WriteLine($"Instalando aplicativo {nomeApp} no aparelho IPhone.."); 
		}
	}
}
