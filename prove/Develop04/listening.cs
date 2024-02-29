public class Listening:Shared
{
    Random rand = new Random();
    private int desiredTime;
    public void getDesiredTime(int desiredTime)
    {

        this.desiredTime = desiredTime;

    }
    List<string> listeningPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private void listeningRandom(List<string> listeningPrompts)
    {
        int index = rand.Next(listeningPrompts.Count);
        Console.WriteLine(listeningPrompts[index]);
    }

    public void listeningActivity(int desiredTime)
    {
        Console.Write("Get ready...");
        animation(5);
        int waitTime = 5;
        int count = 0;
        listeningRandom(listeningPrompts);

        while (waitTime > 0)
        {
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b \b");
            Console.Write($"You may begin in: {waitTime}");
            Thread.Sleep(1000);
            waitTime -= 1;
            
        }
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(desiredTime);
        Console.Clear();
        while (DateTime.Now <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();

            count += 1;
        }
        Console.WriteLine($"You listed {count} items!");



    }

}