using System;
using System.Collections; 

namespace FishTank01
{
	class Program
	{
		public static void Main(string[] args)
		{			
			//build an object.
			Tank Tank1 = new Tank();
			
			//link method in object and write it.
			//*A user should be able to see how much food to put in the tank with a Tank1.Feed().
			//This should return the weight in grams of the total required fish food. 
			Tank1.Feed();
			
			//pause.
			Console.ReadKey(true);
		}
	}
}