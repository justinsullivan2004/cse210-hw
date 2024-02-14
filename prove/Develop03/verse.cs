class Verse
{
    private Reference reference;
    private List<string> words;
    private List<int> hiddenWordIndices;
    private Random random;

    public bool AllWordsHidden => hiddenWordIndices.Count == words.Count;

    public int WordsCount => words.Count;

    public Verse(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').ToList();
        hiddenWordIndices = new List<int>();
        random = new Random();
    }

    public void HideWord()
    {
        int index = random.Next(words.Count);
        if (!hiddenWordIndices.Contains(index))
        {
            hiddenWordIndices.Add(index);
        }
    }
    //had issues with Display since I had a display method in each class 
    //so with the override method to help my classes be more clear about 
    //which class information I am trying to display/use
    public override string ToString()
    {
        string visibleText = string.Join(" ", words.Select((word, index) =>
        {
            return hiddenWordIndices.Contains(index) ? "___" : word;
        }));
        return $"{reference}: {visibleText}";
    }
}