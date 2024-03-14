public class File
{

    List<string> goals;
    public void SaveFile(List<Goal> goals) 
    {

        System.Console.Write("Enter the filename to save the goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {

            foreach (Goal e in goals)
            {

                outputFile.WriteLine(e.Display());

            }
        }
    }

    public static string[] DisplayFile() 
    {
        string loadedLines;


        Console.WriteLine("Enter the File Name of your goals: ");
        string fileName = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }
}


