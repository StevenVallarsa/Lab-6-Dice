using System;

namespace RandomTest
{
    class Program
    {
        static void Main2(string[] args)
        {
                Random r = new Random();
                Random rando = new Random();

                for (int i = 0; i < 11; i++)
                {
                    //Console.WriteLine("The r Random object: " + r.Next(1,7));
                    //Console.WriteLine("the rando Random object: " + rando.Next(1,7));
                    int result = RollDice(1, 6, r);
                    Console.WriteLine(result);
                    result = RollDice(1, 6, r);
                    Console.WriteLine(result);
                    Console.WriteLine();
                }

        }

        public static int RollDice(int min, int max, Random rand)
        {
            int output = rand.Next(min, max + 1);
            return output;
        }

        
    }
}