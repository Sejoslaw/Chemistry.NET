﻿/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Threading.Tasks;
using Chemistry.NET.Tools.Common;

namespace Chemistry.NET.Tools.ElementsGenerator
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            await ToolRunner.Run<ElementsGeneratorToolRunner>();
        }
    }
}
