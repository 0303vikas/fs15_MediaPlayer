namespace src.Core.Repository;

public interface IMedia
{
    public void Play(IStatusMedia status);
    public void Pause(IStatusMedia status);
    public void Stop(IStatusMedia status);
    public void Seek(IStatusMedia status);

}
