//Michael Lawrence.
//Add fishes to tank and write total grams of fish food required.
using System;
using System.Collections;

namespace FishTank01
{
	//build a class to store the fish's name. 
	public class Fish
	{
		public string name { get; set; }
		
	}
	
	public class Tank
	{
		//Fish Food amounts.
		public double GoldFish = 0.1;
		public double AngelFish = 0.2;
		public double BabelFish = 0.3;		
		
		public void Feed()
		{			
			Console.WriteLine("Michael Lawrence's Fish Tank.");
			
			//build a fish object.
			var fish1 = new Fish()
			{
				name = "Gold Fish"
			};
			//build a fish object.
			var fish2 = new Fish()
			{
				name = "Angel Fish"
			};
			//build a fish object.
			var fish3 = new Fish()
			{
				name = "Babel Fish"
			};
			
			//build ArrayList because it expands and want to add more fishes later.
			ArrayList list = new ArrayList();
			//-- Add the fishes into the ArrayList --
			//add the object fish1 to the ArrayList.
			list.Add(fish1);
			//add the object fish2 to the ArrayList.
			list.Add(fish2);
			//add the object fish3 to the ArrayList.
			list.Add(fish3);
			
			//get the index number of the object.
			int loc1 = list.IndexOf(fish1);
			int loc2 = list.IndexOf(fish2);
			int loc3 = list.IndexOf(fish3);			
			
			//write index number.
			//Console.Write(loc1);
			
			//create individual objects for each fish, store in loc1-3 and name them item1-3.
			Fish item1 = (Fish)list[loc1];
			Fish item2 = (Fish)list[loc2];
			Fish item3 = (Fish)list[loc3];
			Console.WriteLine();
			
			//write objects variable name.
			Console.WriteLine(item1.name);
			Console.WriteLine(item2.name);
			Console.WriteLine(item3.name);
			
			
			//add up total fish food required.
			double TotalFishFood = GoldFish + AngelFish + BabelFish;
			Console.WriteLine("------------------------------");
			//write total in grams.
			Console.WriteLine("\nTotal Fish Food reguired: " +TotalFishFood+ "g"); 
		}
	}
} 