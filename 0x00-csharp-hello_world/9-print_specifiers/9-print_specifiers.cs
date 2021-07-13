  
using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		       double currency = 98765.4321;
		       	      Console.WriteLine("Percent: {0}\r\nCurrency: {1}", (percent / 1).ToString("0.00%"), currency.ToString("C2"));
			      }
}