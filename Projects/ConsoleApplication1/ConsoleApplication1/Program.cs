using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Ask the user's name.
// 2. greet the user
// 3. creat a random # generator 1-100 inclusive
// 4. user guesses #
// 5. tell user to go higher or lower
// 6. tell user # of tries it took to get the correct number


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi whats your name");
            string Name = Console.ReadLine();

            Console.WriteLine("Hello {0}!  Let's play a game.  I am thinking of a number between 1 and 100(inclusive).Can you guess it ?", Name);

            Random rndGen = new Random();

            int answer = rndGen.Next(1, 101);
            int guesses = 0;
            bool isPlaying = true;
            while (isPlaying)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == answer)
                {            
                    guesses++;
                    Console.WriteLine(" You Won! it took you {0} guesses ", guesses);
                    Console.WriteLine(" press any key to exit ");
                    isPlaying = false;
                    Console.ReadKey();
                }
                else if (guess < answer)
                {
                    Console.WriteLine(" higher ");
                    guesses++;
                }
                else if (guess > answer)
                {
                    Console.WriteLine(" lower ");
                    guesses++;
                }
            }
        }
    }
}

