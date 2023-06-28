namespace src.Core.Repository;

public interface IMediaFactory
{
    public void Play(string filePath, string fileName);
    public void Pause(string filePath, string fileName);
    public void Stop(string filePath, string fileName);
    public void Seek(string filePath, string fileName);
    public void Dispose();
}
