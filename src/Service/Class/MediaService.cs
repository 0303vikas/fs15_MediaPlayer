using src.Core.Entity;
using src.Core.RepositoryInterface;
using src.Service.Factory;
using src.Service.Interface;
namespace src.Service.Class;

public class MediaService : IMediaService
{
    private IMediaRepository _mediaRepository;
    public MediaService(IMediaRepository mediaRepository)
    {
        _mediaRepository = mediaRepository;
    }
    public void CreateMedia(string filePath, string filename, TimeSpan duration, string fileType, int id)
    {
        _mediaRepository.CreateMedia(filePath, filename, duration, fileType, id);
    }

    public void DeleteOneMedia(int id)
    {
        _mediaRepository.DeleteOneMedia(id);
    }

    public void GetAllMedia()
    {
        _mediaRepository.GetAllMedia();
    }

    public void GetOneMedia(int id)
    {
        _mediaRepository.GetOneMedia(id);
    }
}




