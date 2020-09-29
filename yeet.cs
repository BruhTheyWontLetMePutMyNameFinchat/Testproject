using System;

namespace Coding_stuff
{
    class program
    {
        static void Main(string[] args)
        {
  
            Random numberGen = new Random();
            int number = numberGen.Next(1,11);
            Console.WriteLine("Put in number 1-10");
            int randomnumber = 1000;
            while(randomnumber != number)
            {
            int guess = Convert.ToInt32(Console.ReadLine());
            if(guess == number)
            {
                Console.WriteLine("Nice");
                break;
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Guess higher");
            }
            }
        }
    }
}