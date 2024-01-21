using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string magic = Console.ReadLine();
        // int number = int.Parse(magic);

        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);

        int guessNum = -1;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (guessNum < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessNum != number);
    }
}