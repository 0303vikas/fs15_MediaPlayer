namespace src.Core.Factory;

public class MediaFactory : IDisposable, IMediaFactory
{
    private string _player = "new MediaPlayerInstance()";   // Media Player Instance property

    public MediaFactory() { }

    public string MediaPlayer()
    {
        return _player;
    }

    public void Dispose()
    {
        // Close Instance "_player.close();"
        _player = string.Empty;
    }
}
