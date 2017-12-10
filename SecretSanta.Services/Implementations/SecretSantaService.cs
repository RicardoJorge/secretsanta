using SecretSanta.Data.Contracts;
using SecretSanta.Model;
using SecretSanta.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretSanta.Services.Implementations
{
    public class SecretSantaService : ISecretSantaService
    {
        private readonly IDataLoader dataLoader;
        private readonly ISantaGroupGenerator santaGroupGenerator;

        public SecretSantaService(IDataLoader dataLoader, ISantaGroupGenerator santaGroupGenerator)
        {
            this.dataLoader = dataLoader;
            this.santaGroupGenerator = santaGroupGenerator;
        }

        public async Task LoadSantaGroupAndSendTexts()
        {
            //load santa group
            var friendGroup = await this.dataLoader.GetFriendGroupAsync();

            //create random attribution for each santa
            var santaGroup = this.santaGroupGenerator.GenerateSantaGroup(friendGroup);

            //send texts to santas
            throw new System.NotImplementedException();
        }
    }
}
