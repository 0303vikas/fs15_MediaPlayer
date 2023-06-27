using System;
using WMPLib;
namespace src.Core.Factory;

public class MediaFactory : IDisposable
{
    private WindowMediaPlayer _play = new WindowMediaPlayer();

    public WindowMediaPlayer ReturnMediaPlayer()
    {
        return _play;
    }

    public void Dispose()
    {
        _play.Dispose();
    }
}
