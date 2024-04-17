using System;

namespace Conversão_de_moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Double QuantiaDolar, TaxaCambio, QuantiaMoeda;

            Console.Write("Digite a quantia em dólares: ");
            QuantiaDolar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de um dólar em moeda estrangeira (por exemplo, euros): ");
            TaxaCambio = Convert.ToDouble(Console.ReadLine());
            QuantiaMoeda = QuantiaDolar * TaxaCambio;
            Console.Write(QuantiaDolar + " dólares equivalem a " + QuantiaMoeda + " moeda estrangeira.");
            Console.ReadKey();
        }
    }
}
