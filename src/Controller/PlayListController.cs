using src.Core.Entity;
using src.Service.Interface;

namespace src.Controller;

public class PlayListController
{
    private IPlayListService _playListService;

    public PlayListController(IPlayListService playListService)
    {
        _playListService = playListService;
    }

    public void Add(Media media)
    {
        _playListService.Add(media);
    }

    public void Remove(Media media)
    {
        _playListService.Remove(media);
    }

    public void ClearAll()
    {
        _playListService.ClearAll();
    }
}
