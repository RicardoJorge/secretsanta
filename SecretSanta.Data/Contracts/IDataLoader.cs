using SecretSanta.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSanta.Data.Contracts
{
    public interface IDataLoader
    {
        IList<Friend> GetFriendGroup();
    }
}
