using src.Core.Entity;
using src.Core.Repository;
using src.Service.Enums;
using src.Service.Repository;

namespace src.Service.Entity;
enum OrganizingMediaService
{
    Asc,
    Desc,

}
public class MediaService : IMediaService
{
    private List<IMedia> _mediaList;
    private static MediaService _instance;
    private static readonly Object _lock = new Object();

    public List<IMedia> MediaList
    {
        get { return _mediaList; }
        set { _mediaList = value; }
    }

    public MediaService Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new MediaService();
                }
            }
            return _instance;
        }
    }

    public MediaService()
    {
        _mediaList = new List<IMedia>();
    }

    public void Adding(Media media)
    {
        if (_mediaList.Contains(media)) throw new ArgumentException("Already there");
        _mediaList.Add(media);
    }

    public void Organizing(OrignizingTypeMediaService organize)
    {

    }

    public Media GetOneByFileName(string name)
    {

    }

    public IEnumerable<Media> GetAll()
    {
        return _mediaList;
    }

    public void Removing(Media media)
    {
        if (!_mediaList.Contains(media)) throw new ArgumentException("Media not found in the list.");
        _mediaList.Remove(media);
    }
}
