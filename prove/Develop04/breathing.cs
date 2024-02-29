public class Breathing:Shared
{
    private int desiredTime;
    public void getDesiredTime(int desiredTime)
    {

        this.desiredTime = desiredTime;

    }
    public void breathingTest(int breatheIn, int breatheOut, int desiredTime)
    {

        Console.WriteLine("How long do you want to breathe in for? ");
        breatheIn = int.Parse(Console.ReadLine());
        Console.WriteLine("How long do you want to breathe out for? ");
        breatheOut = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready . . .");
        animation(5);
        
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(desiredTime);

        while (DateTime.Now < futureTime)
        {
            int breatheInCount = breatheIn;
            int breatheOutCount = breatheOut;
            while (breatheInCount > 0)
            {
                Console.WriteLine("Get ready . . . ");
                Console.WriteLine();
                Console.Write($"Breath in. . . {breatheInCount}");
                Thread.Sleep(1000);
                breatheInCount -= 1;
                Console.Clear();
            }
        
            while (breatheOutCount > 0)
            {
                Console.WriteLine("Get ready . . . ");
                Console.WriteLine();
                Console.Write($"Breath out. . . {breatheOutCount}");
                Thread.Sleep(1000);
                breatheOutCount -= 1;
                Console.Clear();
            }

            


        }
    }
}