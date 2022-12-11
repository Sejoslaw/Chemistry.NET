using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Chemistry.NET.Compounds.Models;
using Chemistry.NET.Elements.Models;
using Chemistry.NET.Particles.Models;

var sb = new StringBuilder();

AddGeneralInfo();

AddCommonPart(typeof(CommonParticles));
AddCommonPart(typeof(ElementStructures));
AddCommonPart(typeof(PhysicalStates));
AddCommonPart(typeof(ElectronShells));
AddCommonPart(typeof(ElementTypes));
AddCommonPart(typeof(CommonElements));
AddCommonPart(typeof(CommonIsotopes));
AddCommonPart(typeof(PeriodicTableGroups));
AddCommonPart(typeof(PeriodicTable));
AddCommonPart(typeof(CommonCompounds));

WriteToFile(sb);

// ===================================================== Implementation =====================================================

void AddGeneralInfo()
{
    sb.Append($"// Author: Krzysztof Dobrzyński{Environment.NewLine}");
    sb.Append($"// Project: Chemistry.NET{Environment.NewLine}");
    sb.Append($"// Source: https://github.com/Sejoslaw/Chemistry.NET{Environment.NewLine}");
    sb.Append($"// Legal: Permissions same as in C# project (check above link).{Environment.NewLine}");
    sb.AppendLine();
}

void AddCommonPart(Type commonsClass)
{
    Console.WriteLine($"Starting processing: {commonsClass.Name}...");
    
    var sectionHeader = GetSectionHeader(commonsClass.Name);

    sb.Append($"/*{Environment.NewLine}");
    sb.Append($"\t/////////////////////////////////////////////////////////////////{Environment.NewLine}");
    sb.Append($"\t//{Environment.NewLine}");
    sb.Append($"\t//{Environment.NewLine}");
    sb.Append($"\t//\t\t{sectionHeader}{Environment.NewLine}");
    sb.Append($"\t//{Environment.NewLine}");
    sb.Append($"\t//{Environment.NewLine}");
    sb.Append($"\t/////////////////////////////////////////////////////////////////{Environment.NewLine}");
    sb.Append($"*/{Environment.NewLine}");
    sb.AppendLine();
    
    foreach (var commonClassProp in commonsClass.GetProperties())
    {
        var commonClassPropType = commonClassProp.PropertyType;
        var commonClassPropValue = commonClassProp.GetValue(null);
        
        var defPrefix = $"{commonClassPropType.Name}_{commonClassProp.Name}"; // i.e.: Quark_Up

        foreach (var entryProp in commonClassPropType.GetProperties())
        {
            var defEntryName = $"{defPrefix}_{entryProp.Name}";
            var entryValue = BuildEntryValue(commonClassPropValue, entryProp);

            if (entryValue == null)
            {
                continue;
            }
            
            var defEntry = $"#define {defEntryName} {entryValue}{Environment.NewLine}";
                
            sb.Append(defEntry);
        }

        sb.AppendLine();
    }
    
    Console.WriteLine($"Finished processing: {commonsClass.Name}");
}

string GetSectionHeader(string className)
{
    var parts = Regex.Split(className, @"(?<!^)(?=[A-Z])");
    var sectionHeader = string.Join(" ", parts);
    return sectionHeader;
}

object? BuildEntryValue(object? commonClassPropValue, PropertyInfo entryProp)
{
    object? entryPropValue;
    
    try
    {
        entryPropValue = entryProp.GetValue(commonClassPropValue);
    }
    catch (TargetInvocationException e)
    {
        if (e.InnerException is NotImplementedException) // We are aware that some features are not yet implemented
        {
            return null;
        }

        throw;
    }
    
    if (entryProp.PropertyType == typeof(string)) // strings
    {
        return $"\"{entryPropValue}\"";
    }

    if (entryProp.PropertyType == typeof(bool)) // bools
    {
        return ((bool)(entryPropValue ?? false)) ? 1 : 0;
    }

    if (!entryProp.PropertyType.IsPrimitive) // non-primitives
    {
        return null;
    }

    return entryPropValue; // other primitives
}

void WriteToFile(StringBuilder sb)
{
    const string FileName = "/home/{0}/Dev/CSharp/Chemistry.NET/Tools/Chemistry.NET.Tools.CHeaderGenerator/Chemistry.NET.h";

    var content = sb.ToString();
    File.WriteAllText(string.Format(FileName, args[0]), content);
}