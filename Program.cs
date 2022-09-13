namespace Number_guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {



			bool gewonnen = true;
			string weiterspielen = "ja";
			int zahl = 0;

			
			while (weiterspielen == "ja")
            {

				if (gewonnen == true)
                {
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.DarkCyan;

					Console.WriteLine("					 _____________________________________");
					Console.WriteLine("					-|Willkommen zum Number-Guessing game|-");
					Console.WriteLine("					---------------------------------------	"); 
					Console.WriteLine(" 																    	 Versuchen Sie so schnell wie möglich unsere Zufällige generierte Zahl zwischen 1 und 100 herauszufinden");
					Console.ForegroundColor = ConsoleColor.Cyan;            


					Console.WriteLine("																	      		         Bitte geben sie hier eine Zahl zwischen 1 und 100 ein:");

					gewonnen = false;
					Random zufallszahlen = new Random();
					zahl = zufallszahlen.Next(1, 100);
				}
				

				
				bool check = false;
		
				int eingabe = 0;

				while (check == false)
				
				{

					try
				    {
						eingabe = Convert.ToInt32(Console.ReadLine());
				        check = true;
				        Console.WriteLine("");
				    }
				    catch
				    {
						Console.ForegroundColor = ConsoleColor.Red;
				        Console.WriteLine("                 --<|Ihre Eingabe wurde von diesem Programm nicht erkannt. Bitte geben Sie dies erneut ein|>--");
				        check = false;
				    }
				}

				check = false;

				

				if (eingabe < zahl)
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("     					     --<|Die Zahl " + eingabe + " ist zu klein|>--");
				}
				if (eingabe > zahl)
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("     					     --<|Die Zahl " +  eingabe + " ist zu gross|>--");
				}
				
				if (eingabe == zahl)
                {
					Console.Clear();
					gewonnen = true;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("																																																																			                         Sie haben gewonnen!");
					Console.WriteLine("						        ---					");		
					Console.ForegroundColor= ConsoleColor.Cyan;
					Console.WriteLine("					Möchten Sie weiterspielen? [ja|nein]");
					Console.WriteLine("																																																									");
					
					Console.WriteLine("					       	    .-=========-.	");
					Console.WriteLine("					       	     |'-=====-'|	");
					Console.WriteLine("					            _|   .=.   |_	");
					Console.WriteLine("					       	   ((|  {{1}}  |))	");
					Console.WriteLine("					       	     |    |    |	");
					Console.WriteLine("					       	     |__ '`' __|	");
					Console.WriteLine("					       	       _`) (`_		");
					Console.WriteLine("					       	     _|_______|_	");
					Console.WriteLine("					       	    |___________|	");

					weiterspielen = Console.ReadLine();

					if (weiterspielen == "nein")
                    {
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("																																					        Danke für das Spiel!");
						Console.WriteLine("																																											");
						Console.WriteLine("																																																						");
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.WriteLine("					      -Made by Cyril Lutziger-");
					}
					
					
				}
			}
		}

	}
}