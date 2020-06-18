/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Tools.Common.Models
{
    public class GeneratorConfigurationModel
    {
        public string Namespace { get; set; }
        public string ClassComment { get; set; }
        public string ClassName { get; set; }
        public string FileName { get; set; }
    }
}