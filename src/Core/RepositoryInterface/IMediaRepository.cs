using src.Core.Entity;

namespace src.Core.RepositoryInterface;

public interface IMediaRepository
{
    public void Play(int id);
    public void Pause(int id);
    public void Stop(int id);
    public void CurrentPosition(int id);
    public void CurrentStatus(int id);
    public void Duration(int id);
    public void CreateMedia(string filePath, string filename, TimeSpan duration, string fileType, int id);
    public void DeleteOneMedia(int id);
    public IEnumerable<Media> GetAllMedia();
    public Media GetOneMedia(int id);

}
