public class BaseEntity
{
    private readonly Guid _id;
    private DateTime _createdAt;

    public Guid Id
    {
        get
        {
            return _id;
        }
    }
    public DateTime CreatedAt
    {
        get
        {
            return _createdAt;
        }
        set
        {
            _createdAt = value;
        }
    }

    public BaseEntity(DateTime? createdAt = null)
    {
        _id = Guid.NewGuid();
        _createdAt = createdAt is null ? DateTime.Now : (DateTime) createdAt; 
    }
}