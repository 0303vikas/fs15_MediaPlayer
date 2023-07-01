namespace src.Service.Interface;

public interface IMediaService
{
    public void Play();
    public void Pause();
    public void Stop();
    public void CurrentPosition();
    public void CurrentStatus();
    public void Duration();
}
