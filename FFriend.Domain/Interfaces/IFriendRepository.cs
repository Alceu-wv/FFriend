using FFriend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFriend.Domain.Interfaces
{
    public interface IFriendRepository
    {
        Friend GetById(int id);
        void Create(Friend friend);
        List<Friend> GetAll();
        void Delete(int id);
        void Update(Friend friend);
    }
}
