public class Reflection:Shared
{
    Random rand = new Random();
    private int desiredTime;
    public void getDesiredTime(int desiredTime)
    {

        this.desiredTime = desiredTime;

    }
    private List<string> startingPrompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questionPrompt = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private void startingRandom(List<string> startingPrompt)
    {
        int index = rand.Next(startingPrompt.Count);
        Console.WriteLine(startingPrompt[index]);
    }
    private void questionRandom(List<string> questionPrompt)
    {
        int index = rand.Next(questionPrompt.Count);
        Console.Write(questionPrompt[index]);
    }

    public void reflectionActivity(int desiredTime)
    {
        Console.Clear();
        Console.WriteLine("Get ready . . .");
        animation(5);

        startingRandom(startingPrompt);

        Console.WriteLine("Press 'ENTER' when you are ready");
        Console.ReadLine();

        Thread.Sleep(500);
        int countDown = 5;
        while (countDown > 0)
        {
            Console.WriteLine("Now ponder each of the questions as they relate to the prompt");
            Console.WriteLine($"You may begin in {countDown}");
            Thread.Sleep(1000);
            countDown -= 1;
            Console.Clear();
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(desiredTime); 

        while (DateTime.Now <= futureTime)
        {
            questionRandom(questionPrompt);
            animation(3);
            Console.WriteLine();
        }

        


    }

}