using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
	class Program
	{
		static void Main(string[] args)
		{

			string HelloWorld = "Hello World";
			int year = 1492;
			bool dogAtHome = false;
			string date = "03/22/2017";
			double money = 5.45;
			char letter = 'X';

			Console.WriteLine(HelloWorld);
			Console.WriteLine("Columbus sailed the world in " + year);
			Console.WriteLine("It is " + dogAtHome + " that I have a dog at home.");
			Console.WriteLine("Today is " + date);
			Console.WriteLine("I spent $" + money + " on a cheesburger.");
			Console.WriteLine(letter + " marks the spot");


			Console.WriteLine("Please enter any number: ");
			string random = Console.ReadLine();
			int randomNumber = 0;
			if (int.TryParse(random, out randomNumber)) {
				Console.WriteLine("You entered " + random + " which is the number " + randomNumber);
			}
			else {
				Console.WriteLine("That is not a valid number");
			}
			
		}
	}
}
