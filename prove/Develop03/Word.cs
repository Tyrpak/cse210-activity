using System;

public class Word
{
    public string _text = "";
    public bool _isHidden = False;
      
    
    public void Show(string ref1)
    {
       _ref = ref1;
        Console.Clear();
        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
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

    public void GetNewHiddenWord()
    {
        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hidden.Contains(index1) || _hidden.Contains(index2))
        {
            GetNewHiddenWord();
        }
        else
        {
            _hidden.Add(index1);
            _hidden.Add(index2);

        }
    }


}