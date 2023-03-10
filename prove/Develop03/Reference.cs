

public class Reference
{
    private string _book = "";
    private string _chapter = "";
    private string _verse = "";
    private string _endVerse = "";
    private Boolean _verses = false;

    public Reference(string book)
    {
        _book = book;
        _chapter = "Unknown";
        _verse = "";
    }

     public Reference(string book, string chapter)
    {
         _book = book;
        _chapter = chapter;
        _verse = "";
    }

     public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

     public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _verses = true;
    }

    public string GetReference()
    {   
        string scriptureReference;
        if (!_verses)
        {
            scriptureReference = _book.ToUpper() + "" + _chapter + ":" + _verse;
        }
        else
        {
            scriptureReference = _book + "" + _chapter + ":" + _verse + "-" + _endVerse;
        }
        return scriptureReference;
    }
}