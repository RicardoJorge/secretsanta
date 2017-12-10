using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SecretSanta.Data.Implementations;
using SecretSanta.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSanta.Data.Tests
{
    [TestClass]
    public class FileLoaderTest
    {
        private FileLoader FileLoaderMock;

        [TestInitialize]
        public void Initialzie()
        {
            this.FileLoaderMock = new Mock<FileLoader>().Object;
        }

        [TestMethod]
        public void LoadDataFileForType_GetsExistingType_LoadsStream()
        {
            //arrage

            //act
            var result = this.FileLoaderMock.LoadDataFileForTypeAsync(typeof(FriendGroup));

            //assert
            Assert.IsNotNull(result);
        }
    }
}
