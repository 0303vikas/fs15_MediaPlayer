using src.Core.Entity;

namespace src.Core.RepositoryInterface;

public interface IUserRepository
{
    public void AddPlayList(PlayList playList);
    public void RemoveOnePlayList(PlayList playList);
    public void ClearPlayList();
    public IEnumerable<PlayList> GetPlayList();
}
