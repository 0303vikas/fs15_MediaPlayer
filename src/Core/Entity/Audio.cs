namespace src.Core.Entity;

public class Audio : Media
{
    public Audio(string filePath, string fileName, TimeSpan duration) : base(filePath, fileName, duration)
    {
    }
}
