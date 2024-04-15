public class Book : Base
{
    private string _title;
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }

    public Book() { }
    public Book(string title)
    {
        _title = title;
    }

}