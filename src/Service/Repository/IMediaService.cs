using src.Core.Entity;
using src.Core.Repository;
using src.Service.Enums;

namespace src.Service.Repository;

public interface IMediaService
{
    public void Adding(Media media);
    public void Removing(Media media);
    public Media GetOne();
    public IEnumerable<Media> GetAll();
    public void Organizing(OrignizingTypeMediaService organize);
}
