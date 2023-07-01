namespace src.Core.Entity;

public class Video : Media
{
    public Video(string filePath, string fileName, TimeSpan duration) : base(filePath, fileName, duration)
    {
    }
}
