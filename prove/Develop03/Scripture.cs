using System;
using System.Linq;

public class Scripture
{
        
    public string _scriptureText = "And now, my brethren, seeing that ye know the light by which ye may judge, which light is the light of Christ, see that ye do not judge wrongfully; for with that same judgment which ye judge ye shall also be judged.";

    private var _words = _scriptureText.Split(" ");
    private List<> _hidden = new List<Word>();



    public void SetHidden()
    {
       for (var i = 0; i < _words.Length; i++)
        { 
            Word word = new Word;
            _hidden.Add(_words[i], False);



        }

    }

    public void GetWords()
    {
       for (var i = 0; i < _words.Length; i++)
        { 
           
            

        }

    }

    public void GetRenderedText()
    {
       GetWords();
       
       for (var i = 0; i < _words.Length; i++)
        {
            var str = _words[i];
            int len = str.Length;
            string underscore = new String('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{underscore} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }



    }

    public void HideRandowmWords()
    {
        var random = new Random();
        var index1 = random.Next(_words.Length);
        var index2 = random.Next(_words.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            HideRandowmWords();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);

        }
    }

    public void IsCompletelyHidden()
    {

    }


}