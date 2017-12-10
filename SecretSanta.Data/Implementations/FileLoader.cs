using SecretSanta.Data.Contracts;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SecretSanta.Data.Implementations
{
    public class FileLoader : IFileLoader
    {
        private readonly string FilePath = $"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}/JsonData";

        public async Task<string> LoadDataFileForTypeAsync(Type type)
        {
            StreamReader re = File.OpenText($"{FilePath}/{type.Name}.json");

            return await re.ReadToEndAsync();
        }
    }
}
