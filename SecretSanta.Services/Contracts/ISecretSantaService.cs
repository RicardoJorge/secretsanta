using System.Threading.Tasks;

namespace SecretSanta.Services.Contracts
{
    public interface ISecretSantaService
    {
        Task LoadSantaGroupAndSendTexts();
    }
}
