using src.Core.Enum;
using src.Core.RepositoryInterface;
namespace src.Core.Entity;

public abstract class Media : IMediaRepository
{
    private readonly string _filepath;
    private PlayingOptionEnum IsPlaying = PlayingOptionEnum.NotPlaying;
    private readonly Guid _id;
    private TimeSpan _duration;
    private Timer? _playTimer;
    private TimeSpan _currentPosition;
    private DateTime _startTime;

    public string FileName { get; set; }

    public Guid Id
    {
        get { return _id; }
    }

    public Media(string filePath, string fileName, TimeSpan duration)
    {
        _filepath = filePath;
        _duration = duration;
        FileName = fileName;
        _id = Guid.NewGuid();
    }

    public void Play()
    {
        _startTime = DateTime.Now;
        _playTimer = new Timer(CallBackForTimer, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        // Return Media Player Instance which can start, stop of pause
        IsPlaying = PlayingOptionEnum.Playing;
        Console.WriteLine($"Media {FileName} is playing.");
    }

    public void Pause()
    {
        if (IsPlaying == PlayingOptionEnum.Playing)
        {
            _playTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            IsPlaying = PlayingOptionEnum.Paused;
            Console.WriteLine($"Media {FileName} is paused.");
        }
        else
        {
            Console.WriteLine($"Media {FileName} is not playing.");
        }
    }

    public void Stop()
    {
        if (IsPlaying == PlayingOptionEnum.NotPlaying)
        {
            Console.WriteLine($"Media {FileName} is not playing.");
        }
        else
        {
            IsPlaying = PlayingOptionEnum.NotPlaying;
            _playTimer?.Dispose();
            _currentPosition = TimeSpan.Zero;
            Console.WriteLine($"Media {FileName} is closed.");
        }
    }

    public void CurrentPosition()
    {
        Console.WriteLine($"Current Position of the Video: {_currentPosition.Minutes}mins and {_currentPosition.Seconds % 60} seconds");
    }

    public void Duration()
    {
        Console.WriteLine($"The length of the video is: {_duration} mins");
    }

    public void CurrentStatus()
    {
        Console.WriteLine($"Currently, the Video is: {IsPlaying}");
    }

    private void CallBackForTimer(object? state)
    {
        if (IsPlaying == PlayingOptionEnum.Playing)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            _currentPosition = elapsed;

            if (_currentPosition >= _duration) Stop();
        }
    }

    public override string ToString()
    {
        string printString = $"\nName: {FileName}\n,Path: {_filepath}\n, Duration: {_duration}\n";
        return printString;
    }
}
