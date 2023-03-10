


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
        int length = _getWord.Length;
        _Hidden = true;
    }

    public Boolean IsHidden(Word word)
    {
        return false;
    }
}