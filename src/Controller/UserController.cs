using src.Service.Interface;

namespace src.Controller;

public class UserController
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    public void AddPlayList(PlayList playList)
    {
        _userService.AddPlayList(playList);
    }

    public void RemoveOnePlayList(PlayList playList)
    {
        _userService.RemoveOnePlayList(playList);
    }

    public void ClearPlayList()
    {
        _userService.ClearPlayList();
    }

    public void GetPlayList()
    {
        _userService.GetPlayList();
    }
}
