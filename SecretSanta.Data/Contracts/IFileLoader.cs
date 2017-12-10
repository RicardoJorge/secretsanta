using System;
using System.Threading.Tasks;

namespace SecretSanta.Data.Contracts
{
    public interface IFileLoader
    {
        Task<string> LoadDataFileForTypeAsync(Type type);
    }
}
