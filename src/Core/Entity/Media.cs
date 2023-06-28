using src.Core.Repository;
namespace src.Core.Entity;

public class Media
{
    private readonly string _filepath;
    private IMediaFactory _mediaFactory { get; }

    public string FileName { get; set; }

    public string FilePath
    {
        get { return _filepath; }
    }

    public Media(string filePath, string fileName, IMediaFactory mediaFactory)
    {
        _filepath = filePath;
        FileName = fileName;
        _mediaFactory = mediaFactory;
    }

    public void Play()
    {
        _mediaFactory.Play(FilePath, FileName);
    }

    public void Pause()
    {
        _mediaFactory.Pause(FilePath, FileName);
    }

    public void Stop()
    {
        _mediaFactory.Stop(FilePath, FileName);
    }

    public void Seek()
    {

    }

    public void Dispose()
    {

    }


    // public void Seek()
    // {
    //     public void CurrentPosition()
    //     {

    //     }

    //     public void Duration()
    //     {

    //     }

    //     public void CurrentStatus()
    //     {

    //     }

    // }

}
