using System;

public class Reference
{
    // Variables
    public string reference = "";
    private string book = "Moroni";
    private int chapter = 7;
    private int verseStart = 18;
    private int verseEnd = 0;
   

    public string ReferenceDisplay()
    {
        if (verseEnd == 0)
        {
            ReferenceOneVerse();
        }
        else
        {
            ReferenceMoreVerse();
        }
    }

    public string ReferenceOneVerse() => reference = book + " " + chapter + ":" + verseStart;
    public string ReferenceMoreVerse() => reference = book + " " + chapter + ":" + verseStart + "-" + verseEnd;

}