using System.Text;

namespace src.Core.Entity;

public class PlayList
{
    public string _name;
    private int _id;
    private int _userId;

    public List<Media> _mediaList;

    public int Id
    {
        get { return _id; }
    }
    public int UserId
    {
        get { return _id; }
    }

    public PlayList(string playListName, int id)
    {
        _name = playListName;
        _mediaList = new List<Media>();
    }

    public void Add(Media media, int userId)
    {
        if (MatchUserId(userId))
        {
            if (!DuplicateMediaCheck(media)) throw new ArgumentException("Media already exist in the PlayList. Cann't create duplicate.");
            _mediaList.Add(media);
        }
        else Console.WriteLine("PlayList doesn't belong to the user.");

    }

    public void Remove(Media media, int userId)
    {
        if (MatchUserId(userId))
        {
            _mediaList.Remove(media);
        }
        else Console.WriteLine("PlayList doesn't belong to the user.");

    }

    public void ClearAll(int userId)
    {
        if (MatchUserId(userId))
        {
            _mediaList.Clear();
        }
        else Console.WriteLine("PlayList doesn't belong to the user.");
    }

    public bool DuplicateMediaCheck(Media media)
    {
        return _mediaList.Contains(media);
    }

    private bool MatchUserId(int id)
    {
        if (_userId == id) return true;
        return false;
    }
}
