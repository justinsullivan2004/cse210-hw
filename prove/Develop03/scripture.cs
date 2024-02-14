class Scripture
{
    private List<Verse> verses;
    private Random random;
    private int wordsHiddenCount;

    public bool AllWordsHidden => wordsHiddenCount == verses.Sum(v => v.WordsCount);

    public Scripture(Reference reference, string text)
    {
        verses = new List<Verse> { new Verse(reference, text) };
        random = new Random();
    }

    public void AddVerse(Reference reference, string text)
    {
        verses.Add(new Verse(reference, text));
    }

    public void HideWord()
    {
        Verse verse = verses[random.Next(verses.Count)];
        if (!verse.AllWordsHidden)
        {
            verse.HideWord();
            wordsHiddenCount++;
        }
    }
    //had issues with Display since I had a display method in each class 
    //so with the override method to help my classes be more clear about 
    //which class information I am trying to display/use
    public override string ToString()
    {
        return string.Join("\n", verses.Select(v => v.ToString()));
    }
}