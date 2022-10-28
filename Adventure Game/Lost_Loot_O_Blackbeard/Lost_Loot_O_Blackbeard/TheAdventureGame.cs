using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_Loot_O_Blackbeard
{
	internal class Program
	{
		static int pirateScrolls = 0;
		static bool wonGame = false;
		static bool gameEnd = false;
		static string userName;
		static string line1;
		static string line2;
		static int numLines;
		static int i;
		static bool galleyScroll = false;
		static bool captainScroll = false;
		static bool krakenScroll = false;
		static bool cabinScroll = false;

		static void Galley()
		{
			if (galleyScroll == true)
			{
				Console.WriteLine("Bootstrap Bill - " +
				"\n\nAhoy ye 'ave been 'ere before. Be gone, ye filthy dog!" +
				"\n{Press any key to enter}");
				Console.ReadKey();
				Console.Clear();
				return;	
			}

			Console.WriteLine(
				"Quartermaster Spike -" +
				"\n\n'ere we 'ave the galley, where all the ship's grub be prepared." +
				"\nThe 'ead chef o'er there be Bootstrap Bill," +
				"\nWhich shanty do ye want to sing?");

			string song = GUI("What Shall We Do With The Drunken Sailor?", "Blow The Man Down", 5);
			switch (song)
			{
				case "Blow The Man Down":

					Console.WriteLine("Bootstrap Bill - \n\n" +
						"Be someone singin' blow the man down?" +
						"\nWhy that be me favourite shanty. " +
						"\nAhoy matey 'ow did ye know that there be me lucky song?" +
						"\nNow these sea biscuits will taste extra sweet! " +
						"\n'ere be a Pirate Scroll fer yer jolly deed matey.");

					pirateScrolls += 1;
					galleyScroll = true;
					Console.WriteLine("\n\n{Press any key to continue}");
					Console.ReadKey();
					Console.Clear();
					break;
				case "What Shall We Do With The Drunken Sailor?":
					Console.WriteLine("Bootstrap bill - " +
						"\n\nWHAT SHALL WE DO WITH THE DRUNKEN SAILOR?" +
						"\nWHY WE'LL TAKE 'IM TO THE GANGPLANK OF COURSE!" +
						"\nI'LL FEED YE TO THE SEA MONSTERS " +
						"FOR SINGIN' THAT THERE DREADFUL SHANTY!");

					Console.WriteLine("\n\n{Press any key to continue}");
					Console.ReadKey();
					Console.Clear();
					Death();
					break;

			}
		}

		static void Shipwreck()
		{
			Console.WriteLine("Shipwreck ahoy!" +
				"\nNow go an' find me me Pirate Scroll." +
				"\nBe ye goin' to explore that there chest" +
				"\nor dive down to search inside the wreck?");
			string shipwreckDecision = GUI("Explore the chest", "Dive down and search inside the shipwreck", 4);
			switch (shipwreckDecision)
			{
				case "Explore the floating chest":

					Console.WriteLine("Game -\n\nAs you open the chest" +
						"\nan electric eel jumps out and stings you across the face.");

					Console.WriteLine("\n\n{Press any key to continue}");
					Console.ReadKey();
					Console.Clear();

					Death();
					break;
				case "Dive down and search inside the shipwreck":

					Console.WriteLine("Game -" +
						"\n\nYou dive deep down towards the wreck" +
						"\nand sure enough there is a Pirate Scroll floating beneath the surface!");

					Console.WriteLine("\n\n{Press any key to continue}");
					Console.ReadKey();
					Console.Clear();

					captainScroll = true;
					pirateScrolls += 1;
					Console.Clear();
					break;

			}

		}

		static void CaptainsQuarters()
		{
			if (captainScroll == true)
			{
				Console.WriteLine("Captain - " +
				"\n\nAhoy " + userName + " Thank ye fer yer 'elp earlier. Unfortunately there be no more shipwrecks to be spied!" +
				"\n{Press any key to enter}");
				Console.ReadKey();
				Console.Clear();
				return;
			}

			Console.WriteLine(
				"Ahoy matey, I be the Cap'n o' the fine Jolly Roger." +
				"\nI 'eard ye can 'elp me find the lost loot." +
				"\nI be searchin' fer a shipwreck with one o' the pirate scrolls." +
				"\nWhich direction should I 'ead in?");

			string direction = GUI("North East", "North West", 4);
			switch (direction)
			{
				case "North West":
					Console.WriteLine("Captain -" +
						"\n\nShipwreck ahoy!" +
						"\nThere be it. Jolly job " + userName +
						"\n{Press any key to coninue}");
					Console.ReadKey();
					Console.Clear();

					Shipwreck();
					break;
				case "North East":
					Death();
					break;
			}
		}

		static void ShipsDeck1()
		{
			Console.Clear();
			while (pirateScrolls < 2)
			{
				Console.WriteLine("Ye be welcome to the main deck o' The Jolly Roger," +
					"\nnow where would ye like to go?");
				
				
				string firstLocation = GUI("Galley", "Captain's Quarters", 2);
				switch (firstLocation)
				{
					case "Galley":
						Galley();
						break;
					case "Captain's Quarters":
						CaptainsQuarters();
						break;
				}
			}



		}

		static void ShipsDeck2()
		{
			while (pirateScrolls < 4)
			{
				Console.WriteLine("Well done," +
					"\nye now 'ave " + pirateScrolls + " o' the 4 pirate scrolls, " +
					"\nto find yer next one where would ye like to go?");
				string secondLocation = GUI("Stay on the ship's deck", "Go down to the cabins", 3);
				switch (secondLocation)
				{
					case "Stay on the ship's deck":
						KrackenCove();
						break;
					case "Go down to the cabins":
						while (wonGame == false)
						{
							for (i = 0; i < 2; i++)
							{
								Cabins();
							}
							
						}
						break;
				}
			}
		}

		static void KrackenCove()
		{
			if (krakenScroll == true)
			{
				Console.WriteLine("No point 'eadin' aft to kraken cove now." +
				"\nI'd be a elderly pirate before we get there." +
				"\n{Press any key to continue}");
				Console.ReadKey();
				Console.Clear();
				return;
			}


			Console.WriteLine("We be now 'eaded fer kraken's cove," +
				"\na fellow pirate that there goes by Anne Bonny " +
				"\nsays she 'as a pirate scroll fer us. " +
				"\nSee if ye can find 'er.");
			string KrackenCoveDecision = GUI("Look through the telescope", "Climb the mast to get a better view", 4);
			switch (KrackenCoveDecision)
			{
				case "Look through the telescope":
					krakenScroll = true;
					pirateScrolls += 1;
					Console.Clear();
					break;
				case "Climb the mast to get a better view":
					Console.WriteLine("Fell off and died");
					Death();
					break;

			}
		}

		static void Cabins()
		{
			string gamble;
			int randNum;
			Random random = new Random();
			if (i == 0)
			{
				Console.WriteLine("Calico Jack -" +
					"\n\nMe name be Calico Jack." +
					"\nI'll do ye a deal," +
					"\nif ye win this here game o' egyptian ratscrew " +
					"\nye get this here pirate scroll. " +
					"\nWhich card be ye goin' to place down?");
					gamble = GUI("Queen of Diamonds", "3 of Clubs", 7);
			}
			else
			{
				Console.WriteLine("Calico jack -" +
				"\n\nOk I'll let you play again as I have another scroll.");
				gamble = GUI("Queen of Diamonds", "3 of Clubs", 3);
			}
			int randomChoice = random.Next(1, 3);

			if (gamble == "Queen of Diamonds")
			{
				randNum = 1;

			}
			else
			{
				randNum = 2;
			}

			if (randNum == random.Next(1, 3))
			{
				Console.WriteLine("\nCalico Jack - " +
					"\n\nArgg rapscallion." +
					"\nYe won I suppose." +
					"\nWell 'ere be yer Pirate Scroll." +
					"\n\n{Press any key to continue}");
				Console.ReadKey();
				Console.Clear();
				cabinScroll = true;
				pirateScrolls += 1;
				wonGame = true;
			}
			else
			{
				Console.WriteLine("Calico jack -" +
					"\n\nHarharr ye lost." +
					"\n \nGame -" +
					"\n\nCalico Jack takes the Pirate Scroll and dunks it in his rum.");
				wonGame = false;

			}
		}

		static void Finish()
		{
			Console.WriteLine("Finished");
			Console.ReadKey();
		}

		static void Death()
		{
			Console.WriteLine("You died");
			Console.WriteLine("Would you like to play again? ");
			string replay = Console.ReadLine();
			if (replay == "y")
			{
				pirateScrolls = 0;
			}
			else
			{
				Console.WriteLine("The end");
				gameEnd = true;

			}

		}

		static void StartUp()
		{
			Console.WriteLine("Quartermaster Spike -" +
				"\n\nAhoy, matey! Ye be welcome to the greatest game in all the seven seas - Lost loot o' Blackbeard. \nNow what shall I call ye?");
			userName = "First mate " + Console.ReadLine();
			Console.WriteLine("Jolly to meet ye " + userName);
			Console.WriteLine("Press any key to continue}");
			Console.ReadKey();
			Console.Clear();


			Console.WriteLine("Quartermaster Spike -" +
				"\n\nYe be aboard the finest ship the wide world ever did know\n- The Jolly Roger.\n" +
			"There be one problem 'ere though,\nwe 'ave been searchin' fer the treasure\no' the wisest pirate e'er - a certain Master blackbeard\n " +
			"but we cannot find it matey.\n" + "We could really use yer 'elp,\n ye must find the 4 scrolls to complete the map to the treasure\n{Press any key to continue}");

			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("Quartermaster Spike -" +
				"\n\nYe be in to play?");
			GUI("Aye", "No", 3);

		}

		static string GUI(string line1, string line2, int numLines)
		{
			
			Console.WriteLine("   " + line1);
			Console.WriteLine("   " + line2);
			Console.CursorLeft = 0;
			Console.CursorTop = numLines;
			Console.Write(">");
			Console.ReadKey();
			int option = numLines;
			bool exit = false;



			do
			{
				ConsoleKeyInfo choice = Console.ReadKey(true);
				if (choice.Key == ConsoleKey.DownArrow && Console.CursorTop < numLines + 1)
				{
					Console.CursorTop = option;
					Console.CursorLeft = 0;
					Console.Write(" ");
					option++;
					Console.CursorTop = option;
					Console.CursorLeft = 0;
					Console.Write(">");

				}
				else if (choice.Key == ConsoleKey.UpArrow && Console.CursorTop > numLines)
				{
					Console.CursorTop = option;
					Console.CursorLeft = 0;
					Console.Write(" ");
					option--;
					Console.CursorTop = option;
					Console.CursorLeft = 0;
					Console.Write(">");

				}
				else if (choice.Key == ConsoleKey.Enter)
				{
					Console.Clear();
					if (option == numLines)
					{
						return line1;
					}
					else if (option == numLines + 1)
					{
						return line2;
					}
					exit = true;

				}
			} while (exit != true);
			return null;
		}

		static void Main(string[] args)
		{
			StartUp();

			while (true)
			{
				if (gameEnd == true)
				{
					break;
				}
				else if (pirateScrolls < 2)
				{
					ShipsDeck1();
				}
				else if (pirateScrolls < 4)
				{
					ShipsDeck2();
				}
				else
				{
					Finish();
					break;
				}
			}


		}
	}
}

