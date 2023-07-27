using src.Core.Entity;

namespace src.Core.RepositoryInterface;

public interface IUserRepository
{
    public void AddPlayList(int id, PlayList playList, int userId);
    public void RemoveOnePlayList(int id, PlayList playList, int userId);
    public void ClearPlayList(int userId);
    public IEnumerable<PlayList> GetPlayList(int id, int userId);
    public PlayList GetPlayListById(int id, int userId);
}
