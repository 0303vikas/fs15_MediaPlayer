using src.Service.Repository;

namespace src.Controller;

public class MediaController
{
    private IMediaService _mediaService;

    public MediaController(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }
}