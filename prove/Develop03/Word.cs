using System;

public class Word
{
    public string _text = "";
    public bool _isHidden = False;
    
    public Word(string _text, bool _isHidden)
    {

    }
    
    public void Show(string word, bool hidden)
    {
        word1 = word;
        isHidden = hidden;

        if (isHidden = True ){
            
            int len = word1.Length;
            string underscore = new String('_', len);

            word1 = underscore;

        }

        return word1

    }

}