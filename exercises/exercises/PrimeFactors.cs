using System;

namespace exercises
{
    public class PrimeFactors
    {
        private static void Main(string[] args)
        {
            MyFermatFactorization();

            int answer = Factorials.Factorial(8);
            Console.WriteLine("Eight factorial = " + answer + ".");

            Random random = new Random();
            int dieRoll = random.Next(6) + 1; // returns numbers between 1 and 6
            double probability = random.NextDouble(); // returns numbers between 0 and 1
            Console.WriteLine(" Random (1-6): " + dieRoll + "  Probability: " + probability);

            Player player = new Player("Aristos");

            while (player.GetLives() > 0)
            {
                player.AddPoints(100);

                player.Kill();
            }

            Player player2 = new Player("Beatrice");
            int currentScore = player2.Score;
            player2.Score = 50;
        }

        private static void MyFermatFactorization()
        {
            double fermatNumber5 = 4294967297;
            double squareRoot = Math.Round(Math.Sqrt(fermatNumber5));

            Console.WriteLine("The fifth Fermat number is 4,294,967,297.");
            Console.WriteLine("Press <ENTER> to being brute force factorization.");

            Console.ReadKey();

            for (int i = 2; i < squareRoot; i++)
            {
                Console.WriteLine("I tried dividing by " + i + ".");

                double factor = fermatNumber5 % i;
                if (factor == 0)
                {
                    Console.WriteLine("The first factor is " + i + ".");
                    break;
                }
            }
        }
    }
}