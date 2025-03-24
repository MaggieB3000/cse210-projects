using System;

class Comment
{
    private string _username
private string _commentText

public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;
    }

    public void SetUsername()
    {
        Console.Write("Enter commentor's username: ");
        string _username = Console.ReadLine();
    }
    public void SetCommentText()
    {
        Console.Write("Enter comment text: ");
        string _commentText = Console.ReadLine();
    }
    public string GetUsername()
    {
        return _username;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
    public string FormatedComment()
    {
        return $"Username: {_username} Comment Text: {_commentText}"
    }
}