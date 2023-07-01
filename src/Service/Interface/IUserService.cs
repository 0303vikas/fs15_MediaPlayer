using src.Core.Entity;

namespace src.Service.Interface;

public interface IUserService
{
    public void AddPlayList(PlayList playList);
    public void RemoveOnePlayList(PlayList playList);
    public void ClearPlayList();
    public void GetPlayList();
}
