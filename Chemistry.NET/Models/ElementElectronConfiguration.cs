/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Contains the information of the electron configuration of a specified Element.
    /// </summary>
    public partial class ElementElectronConfiguration
    {
        public string Configuration { get; }

        public ElementElectronConfiguration(string configuration)
        {
            Configuration = configuration;
        }
    }
}