using System;

namespace Day_4
{
	class Program
	{
		static void Main(string[] args)
		{
			/*int mainigais = 3;

			if(mainigais < 5) //<, >, ==, != (nav vienāds), <=, >=
			{
				Console.WriteLine("mazāks");
			}
			else
			{
				Console.WriteLine("lielāks");
			}

			string mainigais2 = "si ir virkne";

			if(mainigais2 == "si ir virkne")
			{
				Console.WriteLine("strings ir vienāds");
			}
			else
			{
				Console.WriteLine("strings nav vienāds");
			}
            */
			//uzdevums 2
			Console.WriteLine("Ievadi ciparu: ");
			int stures = Convert.ToInt16(Console.ReadLine());
			if (stures <= 2)
			{
				Console.WriteLine("pa maz stures");
			}
			else
			{
				if (stures == 3)
				{
					Console.WriteLine("trissturis");
				}
				else
				{
					if (stures == 4)
					{
						Console.WriteLine("četrsturis");
					}
					else
					{
						if (stures == 5)
						{
							Console.WriteLine("piecsturis");
						}
						else
						{
							if (stures == 6)
							{
								Console.WriteLine("sešsturis");
							}
							else
							{
								if (stures >= 7)
								{
									Console.WriteLine("Nu jau par daudz");
								}
							}
						}
					}
				}
			}

			switch (stures)
			{
				case 3: 
					Console.WriteLine("triange");
					break;
				case 4:
					Console.WriteLine("Quad");
					break;
				case 5:
					Console.WriteLine("pent");
					break;
				default:
					//Console.WriteLine("kļūda");
					if (stures >= 6)
					{
						Console.WriteLine("parbaude - 6");
					}
					break;

			}

			//uzdevums 3
			Console.WriteLine("ievadi banknotes nominalu:");
			string nominal = Console.ReadLine();

			switch (nominal)
			{
				case "1":
					Console.WriteLine("Geaorge Washington");
					break;
				case "2":
                    Console.WriteLine("Thomas Jefferson");
                    break;
				case "5":
                    Console.WriteLine("Abraham Lincoln");
                    break;
				case "10":
                    Console.WriteLine("Alexander Hamilton");
                    break;
				case "20":
                    Console.WriteLine("Andrew Jackson");
                    break;
				case "50":
                    Console.WriteLine("Ulysses S. Grant");
                    break;
				case "100":
                    Console.WriteLine("Benjamin Franklin");
                    break;
				default:
					Console.WriteLine("Nav tādas banknotes");
					break;

			}

			/*uzdevums1   
			int chk = Parbaude(); (ugly-bugly-needs to be refined)
			Console.WriteLine(chk);

			if (chk < 5)
			{
				Console.WriteLine("#");
			}
			else
			{
				Console.WriteLine("##(lielaks)");
			}
			//Console.WriteLine(Parbaude());
			Console.ReadLine();
		}
		static int Parbaude()
		{
			int izv = 0;
			Console.WriteLine("ievadi ciparu no 0 lidz 9: ");
			char rdlineValue = (char)Console.Read(); // nolasa tikai pirmu simbolu
			if (char.IsDigit(rdlineValue))
			{
				int a = 0;
				a = rdlineValue;
				izv = a;
				Console.WriteLine(rdlineValue + " = rdlineValue");
				Console.WriteLine(a + " = a");
				Console.WriteLine(izv + " = izv");
			}
			else
			{
				Console.WriteLine("Tu neievadji skaitli");

			}
			return izv;
		}*/
	}
        
	
	}
}
