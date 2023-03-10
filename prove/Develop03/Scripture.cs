using System;

class Scripture
{
    // Attributes
    private string _scripture;
    private string _verseRef;
    private string _hint;

    // Constructors
    public Scripture(string oneVerse, string scripture)
    {
        _verseRef = oneVerse;
        _scripture = scripture;
        Console.WriteLine($"You will be memorizing this scripture:");
        Console.WriteLine("|" + _verseRef + " " + _scripture + "|");
        Console.WriteLine("Enter a hint that you can refer to when do get stuck: ");
        _hint = Console.ReadLine();
        Console.Clear();
    }
    public Scripture(int numVerse, string multiVerse, string scripture)
    {
        _verseRef = multiVerse;
        _scripture = scripture;
        Console.WriteLine($"You will be memorizing this scripture:");
        Console.WriteLine("|" + _verseRef + " " + _scripture + "|");
        Console.WriteLine("Enter a hint that you can refer to when do get stuck: ");
        _hint = Console.ReadLine();
        Console.Clear();

    }

    // Methods
    public string GiveHintToWords()
    {
        return _hint;
    }

    public string GiveVerseRefToWords()
    {
        return _verseRef;
    }

    public string GiveScriptureToWords()
    {
        return _scripture;
    }
    
}

