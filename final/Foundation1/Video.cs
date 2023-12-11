using System;

public class Video 
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayVideo()
    {
        double lengthMinutes = Math.Floor(_length/60);
        double lengthSeconds = _length - lengthMinutes*60;

        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {lengthMinutes} minutes {lengthSeconds} seconds");
        
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        Console.WriteLine();
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }    
    }
}