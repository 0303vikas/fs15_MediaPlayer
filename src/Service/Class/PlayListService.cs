using src.Core.Entity;
using src.Core.RepositoryInterface;
using src.Service.Interface;
namespace src.Service.Class;

public class PlayListService : IPlayListService
{
    private IPlayListRepository _playListRepository;

    public PlayListService(IPlayListRepository playListRepository)
    {
        _playListRepository = playListRepository;
    }

    public void Add(Media media)
    {
        _playListRepository.Add(media);
    }

    public void ClearAll()
    {
        _playListRepository.ClearAll();

    }

    public void Remove(Media media)
    {
        _playListRepository.Remove(media);
    }
}




