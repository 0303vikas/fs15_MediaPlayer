using System.Text;

namespace src.Core.Entity;

public class User
{
    private readonly int _id;
    private List<PlayList> _playLists;

    public string Name;

    public User(string name, int id)
    {
        _id = id;
        _playLists = new List<PlayList>();
        Name = name;
    }

    public IEnumerable<PlayList> GetPlayList()
    {
        return _playLists;
    }

    public override string ToString()
    {
        StringBuilder printString = new StringBuilder($"PlayList of User: {Name}\n");
        foreach (var item in _playLists)
        {
            printString.Append($"{item.ToString()}");

        }
        return printString.ToString();
    }

    public void AddPlayList(int id, PlayList playList, int userId)
    {
        if (CheckDuplicatePlayList(playList)) throw new Exception("Cann't create duplicate playList.");
        _playLists.Add(playList);
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
