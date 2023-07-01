using System.Text;
using src.Core.RepositoryInterface;

namespace src.Core.Entity;

public class User : IUserRepository
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

    public IEnumerable<PlayList> GetPlayList()
    {
        return _playList;
    }

    public override string ToString()
    {
        StringBuilder printString = new StringBuilder($"PlayList of User: {Name}\n");
        foreach (var item in _playList)
        {
            printString.Append($"{item.ToString()}");

        }
        return printString.ToString();
    }

    public void AddPlayList(PlayList playList)
    {
        if (CheckDuplicatePlayList(playList)) throw new Exception("Cann't create duplicate playList.");
        _playList.Add(playList);
    }

    public void RemoveOnePlayList(PlayList playList)
    {
        if (!CheckDuplicatePlayList(playList)) throw new Exception("PlayList not found in user playlist.");
        _playList.Remove(playList);
    }

    public void ClearPlayList()
    {
        _playList.Clear();
    }

    private bool CheckDuplicatePlayList(PlayList playList)
    {
        if (_playList.Contains(playList)) return true;
        else return false;
    }
}
