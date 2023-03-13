


public class Scripture
{
    List<Word> _wordsOfVerse = new List<Word>();
    Reference _scriptureLocation;
    Boolean _allHidden;

    public Scripture(Reference reference, string verseWords)
    {
        _scriptureLocation = reference;
        _allHidden = false;
             
        string[] verse = verseWords.Split(" ");

        foreach (string word in verse)
        {
            Word newWord = new Word(word);
            _wordsOfVerse.Add(newWord);
        }

        
    }

    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in _wordsOfVerse)
        {
           string newWord = word.GetRenderedText();
           scriptureText = scriptureText + " " + newWord;
        }
        string scripture = _scriptureLocation.GetReference() + " " + scriptureText;
        return scripture;

        
    }

    public void HideWords(int howManyWords)
    {
        int wordCount = _wordsOfVerse.Count() + 1;
        for (int i = 0; i<howManyWords; i++)
        {
            Boolean newWordHidden = false;
            Boolean hidingWord = false;
            do
            {
                int firstRandomNum = new Random().Next(0, wordCount); 
               // Console.WriteLine(firstRandomNum);
                int count = 0;
                foreach(Word word in _wordsOfVerse)
                {   
                    if (word.IsHidden() == false || hidingWord == true)
                    {
                        if (count == firstRandomNum)
                        {
                            hidingWord = true;
                            //Console.WriteLine("Hiding Word");
                            word.Hide();
                            newWordHidden = true;
                            hidingWord = false;
                            // Console.WriteLine("stop");
                        }
                        //Console.WriteLine("check word");
                    }
                    //Console.WriteLine("add count");
                    count = count + 1;
                }
            } while(newWordHidden == false && FullyHidden() == false);
            //Console.WriteLine("out");
        }
    }
                

    public Boolean FullyHidden()
    {
        _allHidden = true;
        // Check if each word is hidden, if not the scripture is not fully hidden.
        foreach (Word word in _wordsOfVerse)
        {
            if (word.IsHidden() == false)
            {
                //Console.WriteLine($"Not Hidden word: {word}");
                _allHidden = false;
            }

        }
        
        return _allHidden;
    }
}