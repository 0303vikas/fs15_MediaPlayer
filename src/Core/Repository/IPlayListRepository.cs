using src.Core.Entity;

namespace src.Core.Repository;

public interface IPlayListRepository
{
    public void Add();
    public void Remove();
    public void ClearAll();
    public IEnumerable<Media> GetAll();
    public Media GetById();
    public string ToString();
}
