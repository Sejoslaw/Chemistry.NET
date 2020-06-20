# Chemistry.NET

## 1. General Overview
**Chemistry.NET** is a .NET library which is used for advanced chemical calculations and work based on core known Elements and Particles. The library will give user a set of models and tools to operate on.

### 1.1. Library structure
The whole library was structured out of layers:
Layer | Name | Description
------|------|-------------
1 | Particles | This is the base layer and it describes anything that relates to particles. As it is the lowest layer it should be independent from any other layer. (140+ particles preconfigured)
2 | Elements | This layer lays on top of the Particles layer. It describes everything about core, known elements with their properties and functionality. (118 elements preconfigured)
2 | Isotopes | Contains information about known isotopes and their properties. (6500+ isotopes preconfigured)
3 | Compounds | This is a higher-level layer which let's user build advanced compounds from known elements and isotopes. (2400+ compounds preconfigured)
3 | Ions | Describes ionization functionality for each of the elements. (540+ ions preconfigured)
4 | Molecules | Contains information which can be used to indicate Molecule-related properties for a Chemical Compound.
X | Lipids | TBA
X | Steroids | TBA
X | Polymers | TBA
X | Amino Acids | TBA
X | Sugars | TBA
X | Proteins | TBA

### 1.2. Core Models
Core models around which the whole library is build:

Model Name | Models Collection | Description
-----------|-------------------|--------------
[Element](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET/Elements/Models/Element.cs) | [Common Elements](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/CommonElements.cs) | Represent a single Element known from Periodic Table (i.e. Oxygen, Hydrogen, etc.)
[Element Shells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronShell.cs) and [Subshells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronSubShell.cs) | [ElectronShells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronShells.cs) | Represents electron shells around the center of an Element (i.e. 1s1, 1s2, etc.)
[Element Type](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementType.cs) | [Element Types](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementTypes.cs) | Represents a type of an Element (i.e. Basic Metal, Alkaline Metal, Halogen, etc.)
[Physical State](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PhysicalState.cs) | [Physical States](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PhysicalStates.cs) | Represents a physical state of an Element (i.e. Solid, Liquid, etc.)
[Particle](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Particles/Models/Particle.cs) | [Common Particles](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Particles/Models/CommonParticles.cs) | Represents a particle / antiparticle from which the Elements are build of (i.e. Quarks / AntiQuarks, Neutrino / AntiNeutrino, etc.)
[Element Structure](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementStructure.cs) | [Element Structures](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementStructures.cs) | Represents a structure of an Elements (i.e. number of protons / electrons / neutrons, etc.)
[Periodic Table Element](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PeriodicTableElement.cs) | [Periodic Table](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PeriodicTable.cs) | Represents a classical Element inside the Periodic Table with it's position in the table
[Isotope](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/Isotope.cs) | [Isotopes](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/CommonIsotopes.cs) | Represents an Isotope of a certain Element (6500+ isotopes)

</br>

## 2. Chemical Compounds
Chemical Compounds are a set of higher-level classes based on Core Models.

### 2.2. Higher-Level Models
A set of models which can be used to perform more advanced higher-level calculations:

Model Name | Description
-----------|--------------
[Chemical Compound](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Compounds/Models/ChemicalCompound.cs) | Represent a single Chemical Compound (i.e. H2O, CH4, etc.)
[Common Compounds](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Compounds/Models/CommonCompounds.cs) | Contains a useful collection of common Chemical Compounds (2400+ compounds)

### 2.3. Chemical Compound Parsers
In general, they are used for parsing to / from string representtion into [Chemical Compound](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Compounds/Models/ChemicalCompound.cs)

Name | Working ways | Description
-----|--------------|-------------
[Condensed](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Compounds/Parsers/ChemicalCompounds/CondensedChemicalCompoundParser.cs) | Read / Write | Used for parsing condensed representation of chemical formulas (i.e. H2O, CH4, CH(OH)3, etc.)
(W.I.P.) [Lewis](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Compounds/Parsers/ChemicalCompounds/LewisChemicalCompoundParser.cs) | Read | Used for parsing Lewis representation of chemical formulas (i.e. H-H, H-O-H, etc.)

More will be added in the future...

</br>

## 3. Projects

Project Name | Description
-------------|------------
[Chemistry.NET](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET) | Core library with all the models and functionality
[Chemistry.NET.Tests](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET.Tests) | Tests for core library
[Chemistry.NET.Tools.Common](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET.Tools.Common) | Common library for all tools
[Tools](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Tools) | A collection of tools used to make life easier

</br>

## 4. Installation
You can install it via NuGet package:
> dotnet add package Chemistry.NET

Or check it directly on [NuGet Gallery](https://www.nuget.org/packages/Chemistry.NET/)

</br>

## 5. License

[Click Me](https://github.com/Sejoslaw/Chemistry.NET/blob/master/LICENSE)

</br>

## 6. How to start

### 6.1. Use all registered Elements
```csharp
using Chemistry.NET.Common;

// ...

// Perform some work for each registered Element
// Container contains information about all currently supported types:
// i.e. Particles, Elements, Common Compounds, etc.
foreach (var element in Container.Elements)
{
  // Do some work
}
```

### 6.2. If the element is Hydrogen do some work
```csharp
using Chemistry.NET.Elements.Models;

// ...

IEnumerable<Element> myElements;
// Initialize myElements

foreach (var element in myElements)
{
  if (element == CommonElements.Hydrogen)
  {
    // Do some work
  }
}
```

### 6.3. Parse Hydrogen electron shells
```csharp
using Chemistry.NET.Elements.Models;
using Chemistry.NET.Elements.Parsers.ElectronConfigurations;

ElectronConfiguration electronConfiguration = CommonElements.Hydrogen.ElectronConfiguration;
IEnumerable<ElectronShellData> shellsData = ElectronConfigurationParser.Parse(electronConfiguration);

// Do some logic with parsed shells data
```

### 6.4. Parse new Chemical Compound
```csharp
using Chemistry.NET.Compounds.Models;
using Chemistry.NET.Compounds.Parsers.ChemicalCompounds;

// Way #1 use the parser directly
ChemicalCompound compound1 = new CondensedChemicalCompoundParser().Read("H2O");

// Way #2 use the Chemical Compound initializing method
// In this example we can set the chemical name of the compound (second parameter)
ChemicalCompound compound2 = ChemicalCompound.New("H2O", "Water");
```
