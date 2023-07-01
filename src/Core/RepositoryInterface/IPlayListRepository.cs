using src.Core.Entity;

namespace src.Core.RepositoryInterface;

public interface IPlayListRepository
{
    public void Add(Media media);
    public void Remove(Media media);
    public void ClearAll();
    public IEnumerable<Media> GetAll();
    public Media GetById(Guid guid);
}
