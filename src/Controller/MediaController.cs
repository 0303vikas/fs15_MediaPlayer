using src.Core.Entity;
using src.Service.Interface;
namespace src.Controller;

public class MediaController
{
    private IMediaService _mediaService;

    public MediaController(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }

    public void CreateMedia(string filePath, string filename, TimeSpan duration, string fileType, int id)
    {
        _mediaService.CreateMedia(filePath, filename, duration, fileType, id);
    }

    public void DeleteOneMedia(int id)
    {
        _mediaService.DeleteOneMedia(id);
    }

    public void GetAllMedia()
    {
        _mediaService.GetAllMedia();
    }

    public void GetOneMedia(int id)
    {
        _mediaService.GetOneMedia(id);
    }


}