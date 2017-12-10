using SecretSanta.Model;
using System.Collections.Generic;

namespace SecretSanta.Services.Contracts
{
    public interface ISantaGroupGenerator
    {
        IList<Santa> GenerateSantaGroup(FriendGroup friendGroup);
    }
}
