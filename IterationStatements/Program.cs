using System.ComponentModel.DataAnnotations;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
               
                Console.WriteLine("1. Print from 1 to 1000");
				Console.WriteLine("2. Print to 999 by multiples of 3");
				Console.WriteLine("3. Check if two numbers are the same");
				Console.WriteLine("4. Check if a number is even");
				Console.WriteLine("5. Check if a number is positive");
				Console.WriteLine("6. Check if within legal age to consume alcohol");

				Console.WriteLine("7. Check if a number is within 10 from zero");
				Console.WriteLine("8. Show sum of a multiplied number from 1-12");
				Console.WriteLine("\nPlease enter the number for the method you would like to test or Q to Quit:");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "q") break;
                int index;
                if (int.TryParse(userInput, out index))
                {
                    if (index < 1 || index > 8) Console.WriteLine("Only numbers 1-8 are valid selections.");
                    else
                    {
						switch (index)
						{
                            case 1:
								PrintUpTo1000();
                                break;

                            case 2:
                                PrintTo999By3();
                                break;

                            case 3:
                                Same();
                                break;

                            case 4:
                                IsEven();
                                break;

                            case 5:
                                IsPositive();
                                break;

                            case 6:
                                LegalDrinkingAge();
                                break;

                            case 7:
                                WithinTenOfZero();
                                break;

                            case 8:
                                MultiplicationTable();
                                break;
						}
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
					}
                }
                else Console.WriteLine("Invalid format. Please enter the number for the corresponding method you would like to test.\n");
			}
            Console.WriteLine("Exiting...\n");
        }

		#region Luke Warm

		public static void PrintUpTo1000()
        {
            Console.Clear();
            Console.WriteLine("Press any key to print to 1000!");
            Console.ReadLine();
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine((i).ToString());
            }
			Console.WriteLine("Phew!");

		}

        public static void PrintTo999By3()
        {
			Console.Clear();
			Console.WriteLine("Press any key to print to 999 by multiples of 3!");
			Console.ReadLine();
			int multiplier = 1;
            do
            {
				Console.WriteLine(( 3 * multiplier).ToString());
                multiplier++;
			} while ( 3 * multiplier <= 999);
		}

        public static bool Same()
        {
            int[] numberValues = new int[2];

            bool firstEntryValid = false;
            do
            {
                Console.WriteLine("Type a number:");
                firstEntryValid = int.TryParse(Console.ReadLine(), out numberValues[0]);
                if (!firstEntryValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!firstEntryValid);

            bool secondEntryValid = false;
            do
            {
				Console.WriteLine("Now Type a number to compare to the last:");
				secondEntryValid = int.TryParse(Console.ReadLine(), out numberValues[1]);
				if (!secondEntryValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!secondEntryValid);

            bool isSame = numberValues[0] == numberValues[1];
            if (isSame) Console.WriteLine($"{numberValues[0]} is the same as {numberValues[1]}");
            else Console.WriteLine($"{numberValues[0]} is NOT the same as {numberValues[1]}");
			Console.WriteLine("\n");

			return isSame;
        }

        public static bool IsEven()
        {
            int num;

			bool numValid = false;
            do
            {
                Console.WriteLine("Type a number:");
                numValid = int.TryParse(Console.ReadLine(), out num);
                if (!numValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

            } while (!numValid);

			bool even = (num % 2 == 0);
			if (even) Console.WriteLine($"{num} is an EVEN number");
			else Console.WriteLine($"{num} is an ODD number");
			Console.WriteLine("\n");

			return even;
        }

        public static bool IsPositive()
        {
			int num;

			bool numValid = false;
			do
			{
				Console.WriteLine("Type a number:");
				numValid = int.TryParse(Console.ReadLine(), out num);
				if (!numValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!numValid);

			bool positive = num >= 0;
			if (positive) Console.WriteLine($"{num} is a positive number");
			else Console.WriteLine($"{num} is a negative number");
			Console.WriteLine("\n");

			return positive;
        }

        public static bool LegalDrinkingAge()
        {
			int age;

			bool numValid = false;
			do
			{
				Console.WriteLine("What age are you?");
				numValid = int.TryParse(Console.ReadLine(), out age);
				if (!numValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!numValid);

			bool legal = age >= 21;
			if (legal) Console.WriteLine($"{age} is old enough to drink!");
			else Console.WriteLine($"{age} is not above the minimum drinking legal age.");
			Console.WriteLine("\n");

			return legal;
		}

		#endregion


		#region Heatin Up

        public static bool WithinTenOfZero()
        {
			int num;

			bool numValid = false;
			do
			{
				Console.WriteLine("Type a number:");
				numValid = int.TryParse(Console.ReadLine(), out num);
				if (!numValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!numValid);

			bool inRange = num >= 0;
			if (inRange) Console.WriteLine($"{num} is above or below zero within 10");
			else Console.WriteLine($"{num} is NOT above or below zero within 10");
			Console.WriteLine("\n");

			return num >= -10 && num <= 10;
        }

        public static void MultiplicationTable()
        {
			int num;

			bool numValid = false;
			do
			{
				Console.WriteLine("Type a number to multiply:");
				numValid = int.TryParse(Console.ReadLine(), out num);
				if (!numValid) Console.WriteLine("Invalid Entry. Only numbers are acceptable.");

			} while (!numValid);

			for (int i = 1; i <= 12; i++)
			{
				Console.WriteLine($"{i} x {num} = {i * num}");
			}
			Console.WriteLine("\n");
        }

        

		#endregion

	}
}
