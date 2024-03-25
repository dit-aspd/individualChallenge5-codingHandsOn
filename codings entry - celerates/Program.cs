using System;

public class Program
{
    static void Main(string[] args)
    {
        int i;

        DateTime startTime = DateTime.Now;

        newGame game = new newGame();
        
        System.Console.WriteLine("Hi traveler, only between 1-10, can you guess my favorite number?\n");

        while(true)
        {
            System.Console.WriteLine("Your guess [1-10]: ");

            if(!int.TryParse(Console.ReadLine(), out i) || i < 1 || i > 10)
            {
                System.Console.WriteLine("Bro, I just said only between 1-10.");
                continue;
            }

            if (game.Guess(i))
                break;
        }
        
        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;
        double seconds = Math.Round(duration.TotalSeconds, 2);
        System.Console.WriteLine($"Total time spent: {seconds} seconds");
    
        Console.ReadKey();
    }
}

public class newGame
{
    int num;
    int attempts;

    public newGame()
    {
        Random random = new Random();
        num = random.Next(1, 11);
        attempts = 0;
    }

    public bool Guess(int i)
    {

        attempts++;

        if(i < num)
        {
            System.Console.WriteLine("Try higher.");
            return false;

        } else if (i > num) 
        {
            System.Console.WriteLine("Try lower.");
            return false;

        } else 
        {
            System.Console.WriteLine($"Are you just lucky? Yes, my favorite number is {num}.\nTotal attempts: {attempts}");
            return true;
        }
    }
}