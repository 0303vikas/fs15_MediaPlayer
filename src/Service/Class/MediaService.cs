using src.Core.RepositoryInterface;
using src.Service.Interface;
namespace src.Service.Class;

public class MediaService : IMediaService
{
    private IMediaRepository _mediaRepository;
    public MediaService(IMediaRepository mediaRepository)
    {
        _mediaRepository = mediaRepository;
    }

    public void Play()
    {
        _mediaRepository.Play();
    }

    public void Pause()
    {
        _mediaRepository.Pause();
    }

    public void Stop()
    {
        _mediaRepository.Stop();
    }

    public void CurrentPosition()
    {
        _mediaRepository.CurrentPosition();
    }

    public void CurrentStatus()
    {
        _mediaRepository.CurrentStatus();
    }

    public void Duration()
    {
        _mediaRepository.Duration();
    }
}




