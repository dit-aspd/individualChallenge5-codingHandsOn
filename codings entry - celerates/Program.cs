// Aditya Syawal Pratama - 2102057
// Celerates - GDD
// Individual Challenge #5 - Coding Hands On

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i;

        DateTime startTime = DateTime.Now;
        newGame game = new newGame();
        
        playerData player = new playerData("Traveler", 20);
        System.Console.Write("One welcome thou, ");
        player.callMyName();
        System.Console.WriteLine(".");
        System.Console.WriteLine("Thou looks like " + player.Age + " years old human who seems hungry for a challenge.\nOne hereby challenge thou."); 
        System.Console.WriteLine("Only between 1-100, can thou guess One favorite number?\n");

        while(true)
        {
            System.Console.Write("Your guess [1-100]: ");

            if(!int.TryParse(Console.ReadLine(), out i) || i < 1 || i > 100)
            {
                System.Console.WriteLine("Foolish human, One just said only between 1-100.");
                continue;
            }

            if (game.Guess(i))
                break;
        }
        
        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;
        double seconds = Math.Round(duration.TotalSeconds, 2);
        System.Console.WriteLine($"Total time spent: {seconds} seconds\n");
        System.Console.WriteLine("Dev by: Aditya Syawal Pratama (CC BY 4.0)");
        Console.ReadKey();
    }
}

public class playerData {
    
    public string Name;
    public int Age;

    public playerData(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void callMyName()
    {
        System.Console.Write(Name);
    }
}
public class newGame
{
    int num;
    int attempts;

    public newGame()
    {
        Random random = new Random();
        num = random.Next(1, 101);
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
            System.Console.WriteLine($"\nAre thou just lucky? Yes, One favorite number is {num}.\n\nTotal attempts: {attempts}");
            return true;
        }
    }
}