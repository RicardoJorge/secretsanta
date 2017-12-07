using SecretSanta.Data.Contracts;
using SecretSanta.Services.Contracts;

namespace SecretSanta.Services.Implementations
{
    public class SecretSantaService : ISecretSantaService
    {
        private readonly IDataLoader dataLoader;

        public SecretSantaService(IDataLoader dataLoader)
        {
            this.dataLoader = dataLoader;
        }

        public void LoadSantaGroupAndSendTexts()
        {
            //load santa group
            
            //create random attribution for each santa

            //send texts to santas
            throw new System.NotImplementedException();
        }
    }
}
