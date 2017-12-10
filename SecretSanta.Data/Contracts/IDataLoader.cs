using SecretSanta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.Data.Contracts
{
    public interface IDataLoader
    {
        Task<FriendGroup> GetFriendGroupAsync();
    }
}
