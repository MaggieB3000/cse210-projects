using System;
using System.Collections.Generic;

class Comment
{
    private string _username;
    private string _commentText;

    public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;
    }

    public string GetCommentDetails()
    {
        return $"[{_username}]: {_commentText}";
    }
}