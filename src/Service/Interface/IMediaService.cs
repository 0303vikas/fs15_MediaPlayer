using src.Core.Entity;

namespace src.Service.Interface;

public interface IMediaService
{
    public void CreateMedia(string filePath, string filename, TimeSpan duration, string fileType, int id);
    public void DeleteOneMedia(int id);
    public void GetAllMedia();
    public void GetOneMedia(int id);
}
