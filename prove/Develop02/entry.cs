using System.ComponentModel;
using System.Net;

class Entry
{
    public List<Entry>entries;
    public string response;
    public string prompt;
    public string date;
    public string entry;


    public void getEntry(string prompt) {

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("What is your response? ");
        string response = Console.ReadLine();

        this.response = response;

    }

    public string ConstructEntry(string prompt) {

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        entry = $"{prompt}, {response}, {dateText}";

        return entry;
    }

    public void Display() {

        System.Console.WriteLine($"{entry}");

    }
}
