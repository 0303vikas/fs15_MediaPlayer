using System;
namespace src.Core.Factory;

enum PlayingOptions
{
    Playing,
    NotPlaying,
    Paused,

}
public class MediaFactory : IDisposable
{
    private string _player = "new MediaPlayerInstance()";   // Media Player Instance property
    private PlayingOptions IsPlaying = PlayingOptions.NotPlaying;

    public MediaFactory() { }

    public void Play(string filePath, string fileName)
    {
        // Return Media Player Instance which can start, stop of pause
        IsPlaying = PlayingOptions.Playing;
        Console.WriteLine($"Media {fileName} is playing.");
    }

    public void Pause(string filePath, string fileName)
    {
        if (IsPlaying == PlayingOptions.Playing)
        {
            IsPlaying = PlayingOptions.Paused;
            Console.WriteLine($"Media {fileName} is paused.");
        }
        else
        {
            Console.WriteLine($"Media {fileName} is not playing.");
        }
    }

    public void Stop(string filePath, string fileName)
    {
        if (IsPlaying == PlayingOptions.NotPlaying)
        {
            Console.WriteLine($"Media {fileName} is not playing.");
        }
        else
        {
            IsPlaying = PlayingOptions.NotPlaying;
            Console.WriteLine($"Media {fileName} is closed.");
        }
    }

    public void Seek()
    {


    }

    public void Dispose()
    {
        // Close Instance "_player.close();"
        _player = string.Empty;
    }
}
