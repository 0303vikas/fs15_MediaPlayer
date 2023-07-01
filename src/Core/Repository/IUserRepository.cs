using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Core.Entity;

namespace src.Core.Repository
{
    public interface IUserRepository
    {
        public void AddPlayList(PlayList playList);
        public void RemoveOnePlayList(PlayList playList);
        public void ClearPlayList();
        public IEnumerable<PlayList> GetPlayList();
    }
}