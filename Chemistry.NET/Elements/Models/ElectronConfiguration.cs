/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Contains the information of the electron configuration of a specified Element.
    /// </summary>
    public partial class ElectronConfiguration
    {
        public string Configuration { get; }

        public ElectronConfiguration(string configuration)
        {
            Configuration = configuration;
        }
    }
}
