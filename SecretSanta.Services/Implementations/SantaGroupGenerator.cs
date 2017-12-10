using SecretSanta.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using SecretSanta.Model;
using System.Linq;
using SecretSanta.Core;

namespace SecretSanta.Services.Implementations
{
    public class SantaGroupGenerator : ISantaGroupGenerator
    {
        public IList<Santa> GenerateSantaGroup(FriendGroup friendGroup)
        {
            var santaList = new List<Santa>();
            var stackedFriendList = new Stack<Friend>(friendGroup.Friends);
            stackedFriendList = ReorderStackedList(stackedFriendList);

            foreach (var friend in friendGroup.Friends)
            {
                var santa = new Santa()
                {
                    Name = friend.Name,
                    Phone = friend.PhoneNumber
                };
                
                santa.Friend = GetFriendThatIsNotCurrentSanta(stackedFriendList, friend);
                santaList.Add(santa);
            }

            return santaList;
        }

        private Friend GetFriendThatIsNotCurrentSanta(Stack<Friend> stackedFriendList, Friend friend)
        {
            var possibleFriend = stackedFriendList.Peek();
            if (possibleFriend.PhoneNumber != friend.PhoneNumber)
            {
                return stackedFriendList.Pop();
            }
            else
            {
                stackedFriendList = this.ReorderStackedList(stackedFriendList);
                return GetFriendThatIsNotCurrentSanta(stackedFriendList, friend);
            }
        }

        private Stack<Friend> ReorderStackedList(Stack<Friend> stackedFriendList)
        {
            var rnd = new Random();
            var friendGroup = new List<Friend>(stackedFriendList);
            friendGroup.Shuffle(rnd);
            return new Stack<Friend>(friendGroup);
        }
    }
}
