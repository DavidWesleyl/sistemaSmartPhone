using System;


namespace sistemaSmartPhone
{
	internal class Nokia : SmartPhone // Classe "Filha" Nokia, herda de SmartPhone todas as funções
	{
		public Nokia(int numero, string modelo, string imei, int memoria)
			: base(numero, modelo, imei, memoria)
		{

		}

        public override void instalarAplicativo(string nomeApp)
		{
            Console.WriteLine($"Instalando aplicativo {nomeApp} no aparelho Nokia..."); ;
		}
	}
}
