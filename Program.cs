using System;

namespace loops
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] ogrenciListesi = { };
			for (int i = 0; i <= 100000; i++)
			{
				Console.WriteLine(i);

			}
			Console.WriteLine("finished");
			
			Console.ReadLine();
		}
	}
}
