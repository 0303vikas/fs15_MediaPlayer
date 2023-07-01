using src.Core.Entity;
using src.Core.RepositoryInterface;
using src.Service.Interface;
namespace src.Service.Class;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void AddPlayList(PlayList playList)
    {
        _userRepository.AddPlayList(playList);
    }

    public void RemoveOnePlayList(PlayList playList)
    {
        _userRepository.RemoveOnePlayList(playList);
    }

    public void ClearPlayList()
    {
        _userRepository.ClearPlayList();
    }

    public void GetPlayList()
    {
        _userRepository.GetPlayList();
    }

}
