public class Journal
{

    List<string> entries;
    public void SaveFile(List<string> entries) 
    {

        System.Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {

            foreach (string e in entries)
            {

                outputFile.WriteLine(e);

            }



        }

    }

    public static void DisplayFile() {

        Console.WriteLine("Enter the File Name of the Journal");
        string fileName = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)  
        {

            string[] parts = line.Split(",");

            string prompt = parts[0];
            string response = parts[1];
            string date = parts[2];

            Console.WriteLine($"{prompt}, {response}, {date}");
        }

    }

}


