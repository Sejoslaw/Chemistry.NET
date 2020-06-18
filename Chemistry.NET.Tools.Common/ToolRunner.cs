/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Net.Http;
using System.Threading.Tasks;

namespace Chemistry.NET.Tools.Common
{
    public abstract class ToolRunner
    {
        public virtual async Task Run()
        {
            PrintRuntime();
            
            var client = new HttpClient();
            await RetrieveData(client);

            DoWork();
        }
        
        public abstract void PrintRuntime();
        public abstract Task RetrieveData(HttpClient client);
        public abstract void DoWork();

        public static async Task Run<TRunner>() 
            where TRunner : ToolRunner, new()
        {
            var runner = new TRunner();
            await runner.Run();
        }
    }
}
