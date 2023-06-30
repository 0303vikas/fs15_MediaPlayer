using src.Core.Enum;
using src.Core.Factory;
using src.Core.Repository;
namespace src.Core.Entity;

public class Media : IMedia
{
    private readonly string _filepath;
    private PlayingOptionEnum IsPlaying = PlayingOptionEnum.NotPlaying;
    private IMediaFactory _mediaFactory { get; }
    private readonly Guid _id;
    private double _playTimeSeconds;
    private

    public string FileName
    { get; set; }

    public Guid Id
    {
        get { return _id; }
    }

    public Media(string filePath, string fileName, double playTimeLength)
    {
        _filepath = filePath;
        _playTimeSeconds = playTimeLength;
        FileName = fileName;
        _mediaFactory = new MediaFactory();
        _id = Guid.NewGuid();
    }

    public void Play(string filePath, string fileName)
    {
        // Return Media Player Instance which can start, stop of pause
        IsPlaying = PlayingOptionEnum.Playing;
        Console.WriteLine($"Media {fileName} is playing.");
    }

    public void Pause(string filePath, string fileName)
    {
        if (IsPlaying == PlayingOptionEnum.Playing)
        {
            IsPlaying = PlayingOptionEnum.Paused;
            Console.WriteLine($"Media {fileName} is paused.");
        }
        else
        {
            Console.WriteLine($"Media {fileName} is not playing.");
        }
    }

    public void Stop(string filePath, string fileName)
    {
        if (IsPlaying == PlayingOptionEnum.NotPlaying)
        {
            Console.WriteLine($"Media {fileName} is not playing.");
        }
        else
        {
            IsPlaying = PlayingOptionEnum.NotPlaying;
            Console.WriteLine($"Media {fileName} is closed.");
        }
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

    public void Dispose()
    {

    }
}
