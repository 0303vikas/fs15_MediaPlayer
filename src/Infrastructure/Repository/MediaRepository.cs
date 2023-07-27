using src.Core.Entity;
using src.Core.RepositoryInterface;
using src.Service.Factory;

namespace src.Infrastructure.Repository;

public class MediaRepository : IMediaRepository
{
    public List<Media> _mediaList = new();

    public MediaRepository() { }


    public void CreateMedia(string filePath, string filename, TimeSpan duration, string fileType, int id)
    {
        Media newMedia = MediaFactory.CreateBook(filePath, filename, duration, fileType, id);
        _mediaList.Add(newMedia);
    }

    public void CurrentPosition(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.CurrentPosition();
    }

    public void CurrentStatus(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.CurrentStatus();
    }

    public void DeleteOneMedia(int id)
    {
        var findMedia = CheckMediaExist(id);
        _mediaList.Remove(findMedia);
    }

    public void Duration(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.Duration();
    }

    public IEnumerable<Media> GetAllMedia()
    {
        return _mediaList;
    }

    public Media GetOneMedia(int id)
    {
        var findMedia = CheckMediaExist(id);
        return findMedia;
    }

    public void Pause(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.Pause();
    }

    public void Play(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.Play();
    }

    public void Stop(int id)
    {
        var findMedia = CheckMediaExist(id);
        findMedia.Stop();
    }

    private Media CheckMediaExist(int id)
    {
        var findMedia = _mediaList.FirstOrDefault(item => item.Id == id);
        if (findMedia == null) throw new Exception("Media file doesn't exists.");
        return findMedia;
    }
}
