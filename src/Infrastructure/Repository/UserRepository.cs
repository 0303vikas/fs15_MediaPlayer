using src.Core.Entity;
using src.Core.RepositoryInterface;

namespace src.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private List<PlayList> _playList;
    private static UserRepository _instance;
    private static readonly object _lockObject = new object();

    public static UserRepository Instance()
    {
        if (_instance == null)
        {
            lock (_lockObject)
            {
                _instance = new UserRepository();
            }
        }
        return _instance;
    }

    private UserRepository()
    {
        _playList = new List<PlayList>();
    }


    public void AddPlayList(PlayList playList)
    {
        _playList.Add(playList);
    }

    public void ClearPlayList()
    {
        _playList.Clear();
    }

    public IEnumerable<PlayList> GetPlayList()
    {
        throw new NotImplementedException();
    }

    public void RemoveOnePlayList(PlayList playList)
    {
        throw new NotImplementedException();
    }
}
