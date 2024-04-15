public class Book : BaseEntity
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

    public Book(string title, DateTime? createdAt = null) : base(createdAt)
    {
        _title = title;
    }

}