using System;

public class Scripture
{
        
    public string _scriptureText = "And now, my brethren, seeing that ye know the light by which ye may judge, which light is the light of Christ, see that ye do not judge wrongfully; for with that same judgment which ye judge ye shall also be judged.";

    public void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"\n{Reference._reference}: {_scriptureText}");
    }

    public void HideRandomWords()
    {

    }

    public void IsCompletelyHidden()
    {

    }


}