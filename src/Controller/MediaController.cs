using src.Service.Interface;
namespace src.Controller;

public class MediaController
{
    private IMediaService _mediaService;

    public MediaController(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }

    public void Play()
    {
        _mediaService.Play();
    }

    public void Pause()
    {
        _mediaService.Pause();
    }

    public void Stop()
    {
        _mediaService.Stop();
    }

    public void CurrentPosition()
    {
        _mediaService.CurrentPosition();
    }

    public void CurrentStatus()
    {
        _mediaService.CurrentStatus();
    }

    public void Duration()
    {
        _mediaService.Duration();
    }

}