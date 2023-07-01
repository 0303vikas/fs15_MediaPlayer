using src.Core.Entity;

namespace src.Service.Interface;

public interface IPlayListService
{
    public void Add(Media media);
    public void Remove(Media media);
    public void ClearAll();
    public void GetAll();
    public void GetById(Guid guid);

}
