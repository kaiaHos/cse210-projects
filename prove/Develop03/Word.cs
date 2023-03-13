


public class Word
{
    string _getWord;
    Boolean _Hidden = false;
    public Word(string word)
    {
        _getWord = word;
    }

    public void Hide()
    {
        if(!_Hidden)
        {
            int length = _getWord.Length;
            string hiddenWord = "";
            string[] letters = _getWord.Split("");
            for(int i = 0; i<length; i++)
            {
                hiddenWord = hiddenWord + "_ ";
            }
            _getWord = hiddenWord;
            //Console.WriteLine(_getWord);
            _Hidden = true;
        }
    }

    public string  GetRenderedText()
    {
        return _getWord;
    }

    public Boolean IsHidden()
    {
        return _Hidden;
    }
}