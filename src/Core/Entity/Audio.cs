namespace src.Core.Entity;

public class AudioMedia : Media
{
    public AudioMedia(string filePath, string fileName, TimeSpan duration, int id) : base(filePath, fileName, duration, id)
    {
    }
}
