using FFriend.Domain.Entities;
using FFriend.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFriend.Domain.Interfaces
{
    public interface IFriendService
    {
        Friend GetById(int id);
        public List<Friend> GetAll();
        void Create(Friend friend);
        void Delete(int id);
        void Update(Friend friend);
        public List<FriendViewModel> GetAllViewModel();
    }
}
