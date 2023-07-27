namespace src.Core.Entity;

public class VideoMedia : Media
{
    public VideoMedia(string filePath, string fileName, TimeSpan duration, int id) : base(filePath, fileName, duration, id)
    {
    }
}
