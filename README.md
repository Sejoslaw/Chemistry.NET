# Chemistry.NET

## 1. General Overview
**Chemistry.NET** is a .NET library which is used for advanced chemical calculations and work based on core known Elements and Particles. The library will give user a set of models and tools to operate on.

### 1.1. Core Models
Core models around which the whole library is build:

Model Name | Models Collection | Description
-----------|-------------------|--------------
[Element](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET/Elements/Models/Element.cs) | [Elements](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/Elements.cs) | Represent a single Element known from Periodic Table (i.e. Oxygen, Hydrogen, etc.)
[Element Shells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronShell.cs) and [Subshells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronSubShell.cs) | [ElectronShells](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElectronShells.cs) | Represents electron shells around the center of an Element (i.e. 1s1, 1s2, etc.)
[Element Type](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementType.cs) | [Element Types](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementTypes.cs) | Represents a type of an Element (i.e. Basic Metal, Alkaline Metal, Halogen, etc.)
[Physical State](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PhysicalState.cs) | [Physical States](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PhysicalStates.cs) | Represents a physical state of an Element (i.e. Solid, Liquid, etc.)
[Particle](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Particles/Models/Particle.cs) | [Particles](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Particles/Models/Particles.cs) | Represents a particle / antiparticle from which the Elements are build of (i.e. Quarks / AntiQuarks, Neutrino / AntiNeutrino, etc.)
[Element Structure](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementStructure.cs) | [Element Structures](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/ElementStructures.cs) | Represents a structure of an Elements (i.e. number of protons / electrons / neutrons, etc.)
[Periodic Table Element](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PeriodicTableElement.cs) | [Periodic Table](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/PeriodicTable.cs) | Represents a classical Element inside the Periodic Table with it's position in the table
[Isotope](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/Isotope.cs) | [Isotopes](https://github.com/Sejoslaw/Chemistry.NET/blob/master/Chemistry.NET/Elements/Models/Isotopes.cs) | Represents an Isotope of a certain Element (6500+ isotopes)

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

</br>

## 3. Projects

Project Name | Description
-------------|------------
[Chemistry.NET](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET) | Core library with all the models and functionality
[Chemistry.NET.Tests](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Chemistry.NET.Tests) | Tests for core library
[Tools](https://github.com/Sejoslaw/Chemistry.NET/tree/master/Tools) | A collection of tools used to make life easier

</br>

## 4. Installation
You can install it via NuGet package:
> dotnet add package Chemistry.NET

Or check it directly on [NuGet Gallery](https://www.nuget.org/packages/Chemistry.NET/)

</br>

## 5. License

[Click Me](https://github.com/Sejoslaw/Chemistry.NET/blob/master/LICENSE)
