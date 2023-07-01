namespace src.Core.Repository;

public interface IMedia
{
    public void Play();
    public void Pause();
    public void Stop();
    public void CurrentPosition();
    public void CurrentStatus();
    public void Duration();
    public string ToString();

}
