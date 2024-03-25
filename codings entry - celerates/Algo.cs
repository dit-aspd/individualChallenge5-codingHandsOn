using System;

    public class Algo
    {
        int num;
        int attempts;

        public void newGame()
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
                System.Console.WriteLine("Today is {date.DayOfWeek}, Are you just lucky? Yes, my favorite number is {num}.\nTotal attempts: {attempts}");
                return true;
            }
        }
    }