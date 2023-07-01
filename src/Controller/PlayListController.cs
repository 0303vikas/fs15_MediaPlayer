using src.Service.Interface;

namespace src.Controller;

public class PlayListController
{
    private IPlayListService _playListService;

    public PlayListController(IPlayListService playListService)
    {
        _playListService = playListService;
    }

}
