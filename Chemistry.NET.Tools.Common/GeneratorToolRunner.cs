/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Chemistry.NET.Tools.Common.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Chemistry.NET.Tools.Common
{
    public abstract class GeneratorToolRunner : ToolRunner
    {
        private const string Space = "    ";
        
        public override void DoWork()
        {
            var config = GetConfiguration();
            var builder = new StringBuilder();
            
            builder.Append($"/// <summary>" + Environment.NewLine);
            builder.Append($"/// Author: Krzysztof Dobrzyński" + Environment.NewLine);
            builder.Append($"/// Project: Chemistry.NET" + Environment.NewLine);
            builder.Append($"/// Source: https://github.com/Sejoslaw/Chemistry.NET" + Environment.NewLine);
            builder.Append($"/// </summary>" + Environment.NewLine);
            builder.Append(Environment.NewLine);
            builder.Append($"namespace { config.Namespace }" + Environment.NewLine);
            builder.Append("{" + Environment.NewLine);
            builder.Append(Space + $"/// <summary>" + Environment.NewLine);
            builder.Append(Space + $"/// { config.ClassComment }" + Environment.NewLine);
            builder.Append(Space + $"/// </summary>" + Environment.NewLine);
            builder.Append(Space + $"public class { config.ClassName }" + Environment.NewLine);
            builder.Append(Space + "{" + Environment.NewLine);
            
            var lines = GetLines();
            lines.ToList().ForEach(line => builder.Append(Space + Space + line + Environment.NewLine));
            
            builder.Append(Space + "}" + Environment.NewLine);
            builder.Append("}" + Environment.NewLine);
            
            var fileContent = builder.ToString();
            
            File.Delete($"{ config.FileName }.data");
            File.WriteAllText($"{ config.FileName }.data", fileContent);
        }

        public override Task RetrieveData(HttpClient client)
        {
            return Task.CompletedTask;
        }

        public virtual IEnumerable<string> GetLines()
        {
            var options = new ChromeOptions();
            options.AddArgument("incognito");
            
            using IWebDriver driver = new ChromeDriver(options);
            return GetLines(driver);
        }

        public abstract GeneratorConfigurationModel GetConfiguration();
        public abstract IEnumerable<string> GetLines(IWebDriver driver);
    }
}
