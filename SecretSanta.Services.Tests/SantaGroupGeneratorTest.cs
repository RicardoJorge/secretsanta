using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SecretSanta.Model;
using SecretSanta.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretSanta.Services.Tests
{
    [TestClass]
    public class SantaGroupGeneratorTest
    {
        private SantaGroupGenerator santaGroupGenerator;

        [TestInitialize]
        public void Initialize()
        {
            this.santaGroupGenerator = new Mock<SantaGroupGenerator>().Object;
        }

        [TestMethod]
        public void GenerateSantaGroup_GenerateSantaGroup_RetunsValidSantaGroup()
        {
            //arrage
            var friendGroup = new FriendGroup()
            {
                Friends = new List<Friend>()
                {
                    new Friend()
                    {
                        Name = "Ricardo",
                        PhoneNumber = "911111111"
                    },
                    new Friend()
                    {
                        Name = "Nuno",
                        PhoneNumber = "911111112"
                    },
                    new Friend()
                    {
                        Name = "Ana",
                        PhoneNumber = "911111113"
                    }
                }
            };

            //act
            var result = santaGroupGenerator.GenerateSantaGroup(friendGroup);

            //arrange
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.FirstOrDefault().Friend);
            Assert.AreNotEqual(result.FirstOrDefault().Phone, result.FirstOrDefault().Friend.PhoneNumber);
        }
    }
}
