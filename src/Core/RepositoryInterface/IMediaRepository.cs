namespace src.Core.RepositoryInterface;

public interface IMediaRepository
{
    public void Play();
    public void Pause();
    public void Stop();
    public void CurrentPosition();
    public void CurrentStatus();
    public void Duration();
}
