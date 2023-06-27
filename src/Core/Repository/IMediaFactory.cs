using WMPLib;
namespace src.Core.Repository;

public interface IMediaFactory
{
    public WindowMediaPlayer ReturnMediaPlayer();
    public void Dispose();

}
