class Reference
{
    public string Book {get;}
    public int Chapter {get;}
    public int StartVerse {get;}
    public int EndVerse {get;}
    

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    //had issues with Display since I had a display method in each class 
    //so with the override method to help my classes be more clear about 
    //which class information I am trying to display/use
    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}