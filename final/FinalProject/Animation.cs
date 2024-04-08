public class Animation
{
    public void animation1() 
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        while (DateTime.Now <= futureTime)
        {
            Console.Clear();
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
            
        }
    }
    public void animation2() 
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (DateTime.Now <= futureTime)
        {
            Console.Clear();
            Console.Write("\b      \b");
            Console.Write(". ");

            Thread.Sleep(500);
            Console.Write(". ");

            Thread.Sleep(500);
            Console.Write(". ");

            Thread.Sleep(500);

        }
    }

}