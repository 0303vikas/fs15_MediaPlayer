namespace src.Core.Entity;

public class PlayList
{
    private List<Media> _mediaList;
    private string _name;

    public PlayList(string playListName)
    {
        _name = playListName;
        _mediaList = new List<Media>();
    }

    public void Add(Media media)
    {
        if (!DuplicateMediaCheck(media)) throw new ArgumentException("Media already exist in the PlayList. Cann't create duplicate.");
        _mediaList.Add(media);
    }

    public void Remove(Media media)
    {
        _mediaList.Remove(media);
    }

    public void ClearAll()
    {
        _mediaList.Clear();
    }

    public IEnumerable<Media> GetAll()
    {
        return _mediaList;
    }

    public Media GetName(Guid guid)
    {
        Media? findMedia = _mediaList.Find(item => item.Id == guid);
        if (findMedia != null) return findMedia;
        else throw new Exception("Media Not Founc");
    }

    public bool DuplicateMediaCheck(Media media)
    {
        return _mediaList.Contains(media);
    }
}
