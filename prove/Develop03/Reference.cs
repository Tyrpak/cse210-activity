using System;

public class Reference
{
    // Variables
    public string _reference = "";
    private string _book = "Moroni";
    private int _chapter = 7;
    private int _verseStart = 18;
    private int _verseEnd = 0;
   

    public void ReferenceDisplay()
    {
        if (_verseEnd == 0)
            {
                ReferenceOneVerse();
            }
            else
            {
                ReferenceMoreVerse();
            }
        
    }
    public void ReferenceOneVerse()
    {
        _reference = _book + " " + _chapter + ":" + _verseStart;
    }
    public void ReferenceMoreVerse()
    {
        _reference = _book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd;
    }

}