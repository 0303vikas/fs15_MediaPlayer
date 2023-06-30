namespace src.Core.Entity;

public class User
{
    private readonly Guid _id;
    private List<PlayList> _playList;

    public string Name;

    public User(string name)
    {
        _id = Guid.NewGuid();
        _playList = new List<PlayList>();
        Name = name;
    }

}
