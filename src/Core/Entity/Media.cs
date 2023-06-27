using src.Core.Repository;
namespace src.Core.Entity;

public class Media : IMedia, IStatusMedia
{
    private readonly string _filepath;
    private IMediaFactory _mediaFactory { get; }

    public Media(string filepath, IMediaFactory mediaFactory)
    {
        _filepath = filepath;
        _mediaFactory = mediaFactory;
    }

    public void Play()
    {

    }

    public void Pause()
    {

    }

    public void Stop()
    {

    }

    public void Seek()
    {

    }

    public void CurrentPosition()
    {

    }

    public void Duration()
    {

    }

    public void CurrentStatus()
    {

    }

}
