using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SecretSanta.Data.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecretSanta.Model;

namespace SecretSanta.Data.Tests
{
    [TestClass]
    public class DataLoaderTest
    {
        private Mock<FileLoader> FileLoaderMock;

        [TestInitialize]
        public void Initialize()
        {
            this.FileLoaderMock = new Mock<FileLoader>();
        }

        [TestMethod]
        public async Task GetFriendGroup_GetFriendGroup_ReturnsCorrectly()
        {
            //arrange

            //act
            var result = await this.GetTarget(this.FileLoaderMock).GetFriendGroupAsync();

            //assert
            Assert.IsNotNull(result.Friends);
            Assert.AreEqual("Ricardo", result.Friends.FirstOrDefault().Name);
        }

        private DataLoader GetTarget(Mock<FileLoader> fileLoaderMock)
        {
            return new DataLoader(fileLoaderMock.Object);
        }
    }
}
