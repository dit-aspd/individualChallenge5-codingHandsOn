using System;

public class Program
{
    static void Main(string[] args)
    {
        myFavoriteNumber game = new myFavoriteNumber();
        
        System.Console.WriteLine("Hi traveler, only between 1-10, can you guess my favorite number?\n");

        game.newGame();

        bool guessedCorrect = false;

        while(!guessedCorrect)
        {
            System.Console.WriteLine("You guess [1-10]: ");

            if(i < 1 || i > 10)
            {
                System.Console.WriteLine("Bro, I just said only between 1-10.");
                continue;
            }

            guessedCorrect = game.Guess(guess);
        }
    }
}