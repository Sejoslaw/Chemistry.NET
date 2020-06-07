/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Tools.ElementStructureGenerator
{
    public class Data
    {
        public Table Table { get; set; }
    }

    public class Table
    {
        public Columns Columns { get; set; }
        public Row[] Row { get; set; }
    }

    public class Columns
    {
        public string[] Column { get; set; }
    }

    public class Row
    {
        public string[] Cell { get; set; }
    }
}
