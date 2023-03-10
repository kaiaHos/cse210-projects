


public class Scripture
{
    List<Word> _wordsOfVerse = new List<Word>();
    Reference _scriptureLocation;
    Boolean _AllHidden;

    public Scripture(Reference reference, string verseWords)
    {
        _scriptureLocation = reference;
        _AllHidden = false;
             
        string[] verse = verseWords.Split(" ");

        foreach (string word in verse)
        {
            Word newWord = new Word(word);
            _wordsOfVerse.Add(newWord);
        }

        
    }

    public string GetScripture()
    {
        
        string scripture = _scriptureLocation.GetReference() + "";
        return _scriptureLocation.GetReference();

        
    }

    public void HideWords()
    {
        int count = 0;
        int wordCount = _wordsOfVerse.Count() + 1;
        int firstRandomNum = new Random().Next(0, wordCount); 
        int secondRandomNum = new Random().Next(0, wordCount);
        int thirdRandomNum = new Random().Next(0, wordCount);

        foreach(Word word in _wordsOfVerse)
        {
            if (count == firstRandomNum || count == secondRandomNum || count == thirdRandomNum)
            {
                word.Hide();
            }
        }
    }

    public Boolean FullyHidden()
    {
        do
        {
            // Check if each word is hidden, if not the scripture is not fully hidden.
        }while(false);

        return _AllHidden;
    }
}