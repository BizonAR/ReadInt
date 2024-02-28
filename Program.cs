using System;

namespace ReadInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number;
			number = ReadInt(out number);
			Console.WriteLine("Вы ввели число: " + number);
		}
		static int ReadInt(out int number)
		{
			do
			{
				Console.Write("Введите число: ");
			} while (int.TryParse(Console.ReadLine(), out number) == false);
			return number;
		}
	}
}
