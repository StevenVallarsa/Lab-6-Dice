using System;

namespace Lab_6_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine();
            bool play = true;
            Random r = new Random();


            while (play)
            {

                Console.Write("How many sides should each die have? ");
                int diceSides = GetValidatedUserInput();
                Console.WriteLine();

                Console.Write("How many dice would you like to use? ");
                int diceNumber = GetValidatedUserInput();
                Console.WriteLine();

                int rollTotal = RollTotal(diceSides, diceNumber, r);
                Console.WriteLine($"Your dice rolled {rollTotal} total.");
                Console.WriteLine();

                play = ValidateEntry();

            }

            Console.WriteLine("Goodbye. Thanks for playing.");

        }



        // role each dice separately
        public static int RollDice(int min, int max, Random rand)
        {
            int output = rand.Next(min, max + 1);
            return output;
        }



        // add each die roll and return final result
        public static int RollTotal(int sides, int number, Random r)
        {
            int total = 0;

            for (int i = 1; i <= number; i++)
            {
                total += RollDice(1, sides, r);
            }

            return total;
        }



        // make sure user inputs only numbers for dice sides and quantity
        public static int GetValidatedUserInput()
        {
            string result = Console.ReadLine();

            if (int.TryParse(result, out int sidesInt))
            {
                return sidesInt;
            }

            Console.Write("Oops. That's not right. Try again: ");

            int recursiveResult = GetValidatedUserInput();
            return recursiveResult;
        }



        // ask user to continue and validate y/n response
        public static bool ValidateEntry()
        {
            Console.Write("Roll the dice again? (y/n) ");
            string result = Console.ReadLine().ToLower();

            if (result[0] == 'y')
            {
                return true;
            }

            if (result[0] == 'n') 
            {
                return false;
            }

            bool recursiveResult = ValidateEntry();
            return recursiveResult;


        }

    }
}
