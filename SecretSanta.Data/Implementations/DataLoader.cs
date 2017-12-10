using Newtonsoft.Json;
using SecretSanta.Data.Contracts;
using SecretSanta.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SecretSanta.Data.Implementations
{
    public class DataLoader : IDataLoader
    {
        private readonly IFileLoader fileLoader;

        public DataLoader(IFileLoader fileLoader)
        {
            this.fileLoader = fileLoader;
        }

        public async Task<FriendGroup> GetFriendGroupAsync()
        {
            var json = await this.fileLoader.LoadDataFileForTypeAsync(typeof(FriendGroup));

            return JsonConvert.DeserializeObject<FriendGroup>(json);
        }
    }
}
