using System;
using System.Collections.Generic;

class Video
{
    private string _title;
private string _author;
private int _length;
private List<Comment> _commentList;

public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetCommentCount()
    {
        return _commentList.Count;
    }

    public void FormatedVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetCommentCount()}\nComments:");
        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(comment.GetCommentDetails());
        }
        Console.WriteLine();
    }
}