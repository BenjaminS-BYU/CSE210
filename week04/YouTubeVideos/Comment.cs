public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public Comment()
    {
        _name = "Unknown";
        _text = "No comment provided.";
    }
}