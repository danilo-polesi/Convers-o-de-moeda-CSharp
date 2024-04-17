using System;

public class Class1
{
	public Class1()
	{

		Double QuantiaDolar, TaxaCambio, QuantiaMoeda;

		Console.Write("Digite a quantia em dólares: ");
		QuantiaDolar = Convert.ToDouble(Console.ReadLine());
		Console.Write("Digite o valor de um dólar em moeda estrangeira (por exemplo, euros): ");
		TaxaCambio = Convert.ToDouble(Console.ReadLine());
		QuantiaMoeda = QuantiaDolar * TaxaCambio;
		Console.Write(QuantiaDolar+ " dólares equivalem a " +QuantiaMoeda+ " moeda estrangeira.");
		Console.ReadKey();
	}
}
