using src.Core.Entity;
using src.Core.RepositoryInterface;

namespace src.Infrastructure.Repository;

public class PlayListRepository : IPlayListRepository
{
    public List<Media> _mediaFile = new();

    public void Add(Media media)
    {
        _mediaFile.Add(media);
    }

    public void ClearAll()
    {
        _mediaFile.Clear();
    }

    public void Remove(Media media)
    {
        _mediaFile.Remove(media);
    }
}
