

public class User : Base
{
    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public User(string name, DateTime? createdAt = null) : base(createdAt)
    {
        _name = name;
    }
}