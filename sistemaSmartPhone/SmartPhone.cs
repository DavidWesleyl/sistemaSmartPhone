using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaSmartPhone
{
	internal abstract class SmartPhone // Classe Mãe abstrata "SmartPhone" 
	{
		public int Numero { get; set; } // Numero do celular 
		private string Modelo { get; set; } // Modelo do Celular
		private string IMEI { get; set; } // Identificação única do celular
		private int Memoria { get; set; } // Memória do celular

        public SmartPhone(int numero, string modelo, string imei, int memoria)
        {
			Numero = numero;
			Modelo = modelo;
			IMEI = imei;
			Memoria = memoria;
            
        }

        public void Ligar() // Método Ligar
		{
            Console.WriteLine("Ligando..");

        }

		public void receberLigacao() // Método receber ligação
		{
            Console.WriteLine("Recebendo Ligação");

        }

		public abstract void instalarAplicativo(string nomeApp); // Classe Abstrata








	}
}
