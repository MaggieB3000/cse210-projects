using System;

class Video
{
    private string _title
private string _author
private int _length
public List<Comment> _commentList

public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetCommentList()
    {
        return _commentList;
    }

    public void AddComment()
    {
        Console.Write("Enter commentor's username: ");
        string username = Console.ReadLine();
        Console.Write("Enter comment text: ");
        string commentText = Console.ReadLine();
        Comment comment = new Comment(username, commentText);
        _commentList.Add(comment);
    }

    public void AddCommentPreMade(string username, string text)
    {
        Comment comment = new Comment(username, text)
        _commentList.Add(comment);

    }

    public int CountComments()
    {
        int length = _commentList.Count;
        return length;
    }

    public string FormatedVideoInfo(string title, string author, int length, )
    {
        int commentNumber = CountComments;
        return $"Video: {title}\nAuthor: {author}\nLength in Seconds: {length}\nNumber of Comments: {commentNumber}\nComments: {_commentList}"
    }
}