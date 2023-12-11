using System;

public class Comment
{
    private string _username;
    private string _comment;
    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"@{_username}: {_comment}");
    }
}