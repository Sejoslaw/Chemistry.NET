/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    /// <summary>
    /// Container for known Particles.
    /// </summary>
    public static class Particles
    {
        /// <summary>
        /// eV / c^2
        /// </summary>
        private const double eV = 10 ^ 0;
        /// <summary>
        /// MeV / c^2
        /// </summary>
        private const double MeV = 10 ^ 6;
        /// <summary>
        /// GeV / c^2
        /// </summary>
        private const double GeV = 10 ^ 9;

        // Quarks

        public static Quark Up { get; } = new Quark("Up", "u", 2.2 * MeV, 2 / 3, 1 / 2, 1);
        public static Quark Down { get; } = new Quark("Down", "d", 4.7 * MeV, -(1 / 3), 1 / 2, 1);
        public static Quark Charm { get; } = new Quark("Charm", "c", 1.28 * GeV, 2 / 3, 1 / 2, 2);
        public static Quark Strange { get; } = new Quark("Strange", "s", 96 * MeV, -(1 / 3), 1 / 2, 2);
        public static Quark Top { get; } = new Quark("Top", "t", 173.1 * GeV, 2 / 3, 1 / 2, 3);
        public static Quark Bottom { get; } = new Quark("Bottom", "b", 4.18 * GeV, -(1 / 3), 1 / 2, 3);

        // Antiquark

        public static AntiQuark AntiUp { get; } = new AntiQuark("Anti Up", "u", 2.2 * MeV, -(2 / 3), 1 / 2, 1);
        public static AntiQuark AntiDown { get; } = new AntiQuark("Anti Down", "d", 4.7 * MeV, 1 / 3, 1 / 2, 1);
        public static AntiQuark AntiCharm { get; } = new AntiQuark("Anti Charm", "c", 1.28 * GeV, -(2 / 3), 1 / 2, 2);
        public static AntiQuark AntiStrange { get; } = new AntiQuark("Anti Strange", "s", 96 * MeV, 1 / 3, 1 / 2, 2);
        public static AntiQuark AntiTop { get; } = new AntiQuark("Anti Top", "t", 173.1 * GeV, -(2 / 3), 1 / 2, 3);
        public static AntiQuark AntiBottom { get; } = new AntiQuark("Anti Bottom", "b", 4.18 * GeV, 1 / 3, 1 / 2, 3);

        // Leptons

        public static Lepton Electron { get; } = new Lepton("Electron", "e-", 0.511 * MeV, -1, 1 / 2, 1);
        public static Lepton Positron { get; } = new Lepton("Positron", "e+", 0.511 * MeV, 1, 1 / 2, 1);
        public static Lepton Muon { get; } = new Lepton("Muon", "μ-", 105.66 * MeV, -1, 1 / 2, 2);
        public static Lepton AntiMuon { get; } = new Lepton("Anti Muon", "μ+", 105.66 * MeV, 1, 1 / 2, 2);
        public static Lepton Tau { get; } = new Lepton("Tau", "τ-", 1.7768 * GeV, -1, 1 / 2, 3);
        public static Lepton AntiTau { get; } = new Lepton("Anti Tau", "τ+", 1.7768 * GeV, 1, 1 / 2, 3);

        // Neutrino

        public static Neutrino ElectronNeutrino { get; } = new Neutrino("Electron Neutrino", "νe", 1.0 * eV, 0, 1 / 2, 1);
        public static Neutrino MuonNeutrino { get; } = new Neutrino("Muon Neutrino", "νμ", 0.17 * MeV, 0, 1 / 2, 2);
        public static Neutrino TauNeutrino { get; } = new Neutrino("Tau Neutrino", "ντ", 18.2 * MeV, 0, 1 / 2, 3);

        // Antineutrino

        public static AntiNeutrino AntiElectronNeutrino { get; } = new AntiNeutrino("Anti Electron Neutrino", "νe", 1.0 * eV, 0, -(1 / 2), 1);
        public static AntiNeutrino AntiMuonNeutrino { get; } = new AntiNeutrino("Anti Muon Neutrino", "νμ", 0.17 * MeV, 0, -(1 / 2), 2);
        public static AntiNeutrino AntiTauNeutrino { get; } = new AntiNeutrino("Anti Tau Neutrino", "ντ", 18.2 * MeV, 0, -(1 / 2), 3);

        // Bosons

        public static GaugeBoson Photon { get; } = new GaugeBoson("Photon", "γ", 0, 0, 1);
        public static GaugeBoson Gluon { get; } = new GaugeBoson("Gluon", "g", 0, 0, 1);
        public static GaugeBoson ZBoson { get; } = new GaugeBoson("Z Boson", "Z", 91.19 * GeV, 0, 1);
        public static GaugeBoson WBoson { get; } = new GaugeBoson("W Boson", "W", 80.39 * GeV, 0/* TODO: Technically it's +-1 */, 1);
        public static ScalarBoson Higgs { get; } = new ScalarBoson("Higgs", "H", 124.97 * GeV, 0, 0);

        // Hadrons

        // Nucleon

        public static Nucleon Proton { get; } = new Nucleon("Proton", "p+", "u+u+d+", 938.272046 * MeV, 1 / 2, 1 / 2, 1, 0, 0, 0, "Stable", 1 / 2);
        public static Nucleon AntiProton { get; } = new Nucleon("Anti Proton", "p-", "u-u-d-", 938.2720813 * MeV, 1 / 2, 1 / 2, -1, 0, 0, 0, "Stable", 1 / 2);
        public static Nucleon Neutron { get; } = new Nucleon("Neutron", "n", "u+d+d+", 939.56542052 * MeV, 1 / 2, 1 / 2, 0, 0, 0, 0, "(8.800±0.009)×10^2", 1 / 2);
        public static Nucleon AntiNeutron { get; } = new Nucleon("Anti Neutron", "n", "u-d-d-", 939.565560 * MeV, 1 / 2, 1 / 2, 0, 0, 0, 0, "(8.800±0.009)×10^2", 1 / 2);

        // Baryons

        // 1/2

        public static Baryon Lambda0 { get; } = new Baryon("Lambda", "Λ0", "uds", 1115.683 * MeV, 0, 1 / 2, 0, -1, 0, 0, "(2.632±0.020)×10^-10", 1 / 2);
        public static Baryon CharmedLambda { get; } = new Baryon("Charmed Lambda", "Λ+c", "udc", 2286.46 * MeV, 0, 1 / 2, 1, 0, 1, 0, "(2.00±0.06)×10^−13", 1 / 2);
        public static Baryon BottomLambda { get; } = new Baryon("Bottom Lambda", "Λ0b", "udb", 5619.4 * MeV, 0, 1 / 2, 0, 0, 0, -1, "(1.429±0.024)×10^−12", 1 / 2);
        public static Baryon SigmaPlus { get; } = new Baryon("Sigma+", "Σ+", "uus", 1189.37 * MeV, 1, 1 / 2, 1, -1, 0, 0, "(8.018±0.026)×10^−11", 1 / 2);
        public static Baryon Sigma0 { get; } = new Baryon("Sigma 0", "Σ0", "uds", 1192.642 * MeV, 1, 1 / 2, 0, -1, 0, 0, "(7.4±0.7)×10^−20", 1 / 2);
        public static Baryon SigmaMinus { get; } = new Baryon("Sigma-", "Σ-", "dds", 1197.449 * MeV, 1, 1 / 2, -1, -1, 0, 0, "(1.479±0.011)×10^−10", 1 / 2);
        public static Baryon CharmedSigmaPlusPlus { get; } = new Baryon("Charmed Sigma++", "Σ++c", "uuc", 2453.98 * MeV, 1, 1 / 2, 2, 0, 1, 0, "(2.91±0.32)×10^−22", 1 / 2);
        public static Baryon CharmedSigmaPlus { get; } = new Baryon("Charmed Sigma+", "Σ+c", "udc", 2452.9 * MeV, 1, 1 / 2, 1, 0, 1, 0, "1.43×10^−22", 1 / 2);
        public static Baryon CharmedSigma0 { get; } = new Baryon("Charmed Sigma 0", "Σ0c", "ddc", 2453.74 * MeV, 1, 1 / 2, 0, 0, 1, 0, "(3.05±0.37)×10^−22", 1 / 2);
        public static Baryon BottomSigmaPlus { get; } = new Baryon("Bottom Sigma+", "Σ+b", "uub", 5811.3 * MeV, 1, 1 / 2, 1, 0, 0, -1, "6.8×10^−23", 1 / 2);
        public static Baryon BottomSigma0 { get; } = new Baryon("Bottom Sigma 0", "Σ0b", "udb", 0 /* TODO: ??? */, 1, 1 / 2, 0, 0, 0, -1, "Unknown", 1 / 2);
        public static Baryon BottomSigmaMinus { get; } = new Baryon("Bottom Sigma-", "Σ-b", "ddb", 5815.5 * MeV, 1, 1 / 2, -1, 0, 0, -1, "1.34×10^−22", 1 / 2);
        public static Baryon Xi0 { get; } = new Baryon("Xi 0", "Ξ0", "uss", 1314.86 * MeV, 1 / 2, 1 / 2, 0, -2, 0, 0, "(2.90±0.09)×10^−10", 1 / 2);
        public static Baryon XiMinus { get; } = new Baryon("Xi-", "Ξ-", "dss", 1321.71 * MeV, 1 / 2, 1 / 2, -1, -2, 0, 0, "(1.639±0.015)×10^−10", 1 / 2);
        public static Baryon CharmedXiPlus { get; } = new Baryon("Charmed Xi+", "Ξ+c", "usc", 2467.8 * MeV, 1 / 2, 1 / 2, 1, -1, 1, 0, "(4.42±0.26)×10^−13", 1 / 2);
        public static Baryon CharmedXi0 { get; } = new Baryon("Charmed Xi 0", "Ξ0c", "dsc", 2470.88 * MeV, 1 / 2, 1 / 2, 0, -1, 1, 0, "1.12×10^−13", 1 / 2);
        public static Baryon CharmedXiPrimePlus { get; } = new Baryon("Charmed Xi Prime+", "Ξ′+c", "usc", 2575.6 * MeV, 1 / 2, 1 / 2, 1, -1, 1, 0, "Unknown", 1 / 2);
        public static Baryon CharmedXiPrime0 { get; } = new Baryon("Charmed Xi Prime 0", "Ξ′0c", "dsc", 2577.9 * MeV, 1 / 2, 1 / 2, 0, -1, 1, 0, "Unknown", 1 / 2);
        public static Baryon DoubleCharmedXiPlusPlus { get; } = new Baryon("Double Charmed Xi++", "Ξ++cc", "ucc", 3621.4 * MeV, 1 / 2, 1 / 2, 2, 0, 2, 0, "Unknown", 1 / 2);
        public static Baryon DoubleCharmedXiPlus { get; } = new Baryon("Double Charmed Xi+", "Ξ+cc", "dcc", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 1, 0, 2, 0, "Unknown", 1 / 2);
        public static Baryon CascadeB0 { get; } = new Baryon("Xi or Cascade B 0", "Ξ0b", "usb", 5787.8 * MeV, 1 / 2, 1 / 2, 0, -1, 0, -1, "Unknown", 1 / 2);
        public static Baryon CascadeBMinus { get; } = new Baryon("Bottom Xi- or Cascade B-", "Ξ-b", "dsb", 5791.1 * MeV, 1 / 2, 1 / 2, -1, -1, 0, -1, "Unknown", 1 / 2);
        public static Baryon BottomXiPrime0 { get; } = new Baryon("Bottom Xi Prime† 0", "Ξ′0b", "usb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 0, -1, 0, -1, "Unknown", 1 / 2);
        public static Baryon BottomXiPrimeMinus { get; } = new Baryon("Bottom Xi Prime†-", "Ξ′-b", "dsb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, -1, -1, 0, -1, "Unknown", 1 / 2);
        public static Baryon DoubleBottomXi0 { get; } = new Baryon("Double Bottom Xi 0", "Ξ0bb", "ubb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 0, 0, 0, -2, "Unknown", 1 / 2);
        public static Baryon DoubleBottomXiMinus { get; } = new Baryon("Double Bottom Xi-", "Ξ-bb", "dbb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, -1, 0, 0, -2, "Unknown", 1 / 2);
        public static Baryon CharmedBottomXiPlus { get; } = new Baryon("Charmed Bottom Xi+", "Ξ+cb", "ucb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 1, 0, 1, -1, "Unknown", 1 / 2);
        public static Baryon CharmedBottomXi0 { get; } = new Baryon("Charmed Bottom Xi 0", "Ξ0cb", "dcb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 0, 0, 1, -1, "Unknown", 1 / 2);
        public static Baryon CharmedBottomXiPrimePlus { get; } = new Baryon("Charmed Bottom Xi Prime†+", "Ξ′+cb", "ucb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 1, 0, 1, -1, "Unknown", 1 / 2);
        public static Baryon CharmedBottomXiPrime0 { get; } = new Baryon("Charmed Bottom Xi Prime† 0", "Ξ′0cb", "dcb", 0 /* TODO: ??? */, 1 / 2, 1 / 2, 0, 0, 1, -1, "Unknown", 1 / 2);
        public static Baryon CharmedOmega0 { get; } = new Baryon("Charmed Omega 0", "Ω0c", "ssc", 2695.2 * MeV, 0, 1 / 2, 0, -2, 1, 0, "(6.9±1.2)×10^−14", 1 / 2);
        public static Baryon BottomOmegaMinus { get; } = new Baryon("Bottom Omega-", "Ω−b", "ssb", 6071 * MeV, 0, 1 / 2, -1, -2, 0, -1, "(1.13±0.02)×10^−12", 1 / 2);
        public static Baryon DoubleBottomOmegaPlus { get; } = new Baryon("Double Bottom Omega+", "Ω+cc", "scc", 0 /* TODO: ??? */, 0, 1 / 2, 1, -1, 2, 0, "Unknown", 1 / 2);
        public static Baryon CharmedBottomOmega0 { get; } = new Baryon("Charmed Bottom Omega 0", "Ω0cb", "scb", 0 /* TODO: ??? */, 0, 1 / 2, 0, -1, 1, -1, "Unknown", 1 / 2);
        public static Baryon CharmedBottomOmegaPrime0 { get; } = new Baryon("Charmed Bottom Omega Prime† 0", "Ω′0cb", "scb", 0 /* TODO: ??? */, 0, 1 / 2, 0, -1, 1, -1, "Unknown", 1 / 2);
        public static Baryon DoubleBottomOmegaMinus { get; } = new Baryon("Double Bottom Omega†-", "Ω−bb", "sbb", 0 /* TODO: ??? */, 0, 1 / 2, -1, -1, 0, -2, "Unknown", 1 / 2);
        public static Baryon DoubleCharmedBottomOmegaPlus { get; } = new Baryon("Double Charmed Bottom Omega†+", "Ω+ccb", "ccb", 0 /* TODO: ??? */, 0, 1 / 2, 1, 0, 2, -1, "Unknown", 1 / 2);
        public static Baryon CharmedDoubleBottomOmega0 { get; } = new Baryon("Charmed Double Bottom Omega† 0", "Ω0cbb", "cbb", 0 /* TODO: ??? */, 0, 1 / 2, 0, 0, 1, -2, "Unknown", 1 / 2);

        // 3/2

        public static Baryon DeltaPlusPlus { get; } = new Baryon("Delta++", "Δ++ (1232)", "uuu", 1232 * MeV, 3 / 2, 3 / 2, 2, 0, 0, 0, "(5.63±0.14)×10^−24", 3 / 2);
        public static Baryon DeltaPlus { get; } = new Baryon("Delta+", "Δ+ (1232)", "uud", 1232 * MeV, 3 / 2, 3 / 2, 1, 0, 0, 0, "(5.63±0.14)×10^−24", 3 / 2);
        public static Baryon Delta0 { get; } = new Baryon("Delta 0", "Δ0 (1232)", "udd", 1232 * MeV, 3 / 2, 3 / 2, 0, 0, 0, 0, "(5.63±0.14)×10^−24", 3 / 2);
        public static Baryon DeltaMinus { get; } = new Baryon("Delta-", "Δ- (1232)", "ddd", 1232 * MeV, 3 / 2, 3 / 2, -1, 0, 0, 0, "(5.63±0.14)×10^−24", 3 / 2);
        public static Baryon SigmaStarPlus { get; } = new Baryon("Sigma∗+", "Σ∗+ (1385)", "uus", 1382.8 * MeV, 1, 3 / 2, 1, -1, 0, 0, "(1.839±0.0041)×10^−23", 3 / 2);
        public static Baryon SigmaStar0 { get; } = new Baryon("Sigma∗ 0", "Σ∗0 (1385)", "uds", 1383.7 * MeV, 1, 3 / 2, 0, -1, 0, 0, "(1.83±0.25)×10^−23", 3 / 2);
        public static Baryon SigmaStarMinus { get; } = new Baryon("Sigma∗-", "Σ∗- (1385)", "dds", 1387.2 * MeV, 1, 3 / 2, -1, -1, 0, 0, "(1.671±0.089)×10^−23", 3 / 2);
        public static Baryon CharmedSigmaStartPlusPlus { get; } = new Baryon("Charmed Sigma∗++", "Σ∗++c (2520)", "uuc", 2517.9 * MeV, 1, 3 / 2, 2, 0, 1, 0, "(4.42±0.44)×10^−23", 3 / 2);
        public static Baryon CharmedSigmaStartPlus { get; } = new Baryon("Charmed Sigma∗+", "Σ∗+c (2520)", "udc", 2517.5 * MeV, 1, 3 / 2, 1, 0, 1, 0, "3.87×10^−23", 3 / 2);
        public static Baryon CharmedSigmaStart0 { get; } = new Baryon("Charmed Sigma∗ 0", "Σ∗0c (2520)", "ddc", 2518.8 * MeV, 1, 3 / 2, 0, 0, 1, 0, "(4.54±0.47)×10^−23", 3 / 2);
        public static Baryon BottomSigmaStarPlus { get; } = new Baryon("Bottom Sigma∗+", "Σ∗+b", "uub", 5832.1 * MeV, 1, 3 / 2, 1, 0, 0, -1, "(5.7±1.8)×10^−23", 3 / 2);
        public static Baryon BottomSigmaStar0 { get; } = new Baryon("Bottom Sigma∗ 0", "Σ∗0b", "udb", 0 /* TODO: ??? */, 1, 3 / 2, 0, 0, 0, -1, "Unknown", 3 / 2);
        public static Baryon BottomSigmaStarMinus { get; } = new Baryon("Bottom Sigma∗-", "Σ∗-b", "ddb", 5835.1 * MeV, 1, 3 / 2, -1, 0, 0, -1, "8.8×10^−23", 3 / 2);
        public static Baryon XiStar0 { get; } = new Baryon("Xi∗ 0", "Ξ∗0 (1530)", "uss", 1531.8 * MeV, 1 / 2, 3 / 2, 0, -2, 0, 0, "(7.23±0.40)×10^−23", 3 / 2);
        public static Baryon XiStarMinus { get; } = new Baryon("Xi∗-", "Ξ∗- (1530)", "dss", 1535 * MeV, 1 / 2, 3 / 2, -1, -2, 0, 0, "6.6×10^−23", 3 / 2);
        public static Baryon CharmedXiStarPlus { get; } = new Baryon("Charmed Xi∗+", "Ξ∗+c (2645)", "usc", 2645.9 * MeV, 1 / 2, 3 / 2, 1, -1, 1, 0, "2.1×10^−22", 3 / 2);
        public static Baryon CharmedXiStar0 { get; } = new Baryon("Charmed Xi∗ 0", "Ξ∗0c (2645)", "dsc", 2645.9 * MeV, 1 / 2, 3 / 2, 0, -1, 1, 0, "1.2×10^−22", 3 / 2);
        public static Baryon DoubleCharmedXiStarPlusPlus { get; } = new Baryon("Double Charmed Xi∗++", "Ξ∗++cc", "ucc", 0 /* TODO: ??? */, 1 / 2, 3 / 2, 2, 0, 2, 0, "Unknown", 3 / 2);
        public static Baryon DoubleCharmedXiStarPlus { get; } = new Baryon("Double Charmed Xi∗+", "Ξ∗+cc", "dcc", 0 /* TODO: ??? */, 1 / 2, 3 / 2, 1, 0, 2, 0, "Unknown", 3 / 2);
        public static Baryon BottomXiStar0 { get; } = new Baryon("Bottom Xi∗ 0", "Ξ∗0b", "usb", 5945.5 * MeV, 1 / 2, 3 / 2, 0, -1, 0, -1, "(3.1±2.5)×10^−22", 3 / 2);
        public static Baryon BottomXiStartMinus { get; } = new Baryon("Bottom Xi∗-", "Ξ∗-b", "dsb", 0 /* TODO: ??? */, 1 / 2, 3 / 2, -1, -1, 0, -1, "Unknown", 3 / 2);
        public static Baryon DoubleBottomXiStar0 { get; } = new Baryon("Double Bottom Xi∗ 0", "Ξ∗0bb", "ubb", 0 /* TODO: ??? */, 1 / 2, 3 / 2, 0, 0, 0, -2, "Unknown", 3 / 2);
        public static Baryon DoubleBottomXiStarMinus { get; } = new Baryon("Double Bottom Xi∗-", "Ξ∗-bb", "dbb", 0 /* TODO: ??? */, 1 / 2, 3 / 2, -1, 0, 0, -2, "Unknown", 3 / 2);
        public static Baryon DoubleBottomXiStarPlus { get; } = new Baryon("Double Bottom Xi∗+", "Ξ∗+bb", "ucb", 0 /* TODO: ??? */, 1 / 2, 3 / 2, 1, 0, 1, -1, "Unknown", 3 / 2);
        public static Baryon CharmedBottomXiStar0 { get; } = new Baryon("Charmed Bottom Xi∗ 0", "Ξ∗0cb", "dcb", 0 /* TODO: ??? */, 1 / 2, 3 / 2, 0, 0, 1, -1, "Unknown", 3 / 2);
        public static Baryon OmegaMinus { get; } = new Baryon("Omega-", "Ω−", "sss", 1672.45 * MeV, 0, 3 / 2, -1, -3, 0, 0, "(8.21±0.11)×10^−11", 3 / 2);
        public static Baryon CharmedOmegaStar0 { get; } = new Baryon("Charmed Omega∗ 0", "Ω∗0c (2770)", "ssc", 2765.9 * MeV, 0, 3 / 2, 0, -2, 1, 0, "Unknown", 3 / 2);
        public static Baryon BottomOmegaStarMinus { get; } = new Baryon("Bottom Omega∗-", "Ω∗−b", "ssb", 0 /* TODO: ??? */, 0, 3 / 2, -1, -2, 0, -1, "Unknown", 3 / 2);
        public static Baryon DoubleCharmedOmegaStarPlus { get; } = new Baryon("Double Charmed Omega∗+", "Ω∗+cc", "scc", 0 /* TODO: ??? */, 0, 3 / 2, 1, -1, 2, 0, "Unknown", 3 / 2);
        public static Baryon CharmedBottomOmegaStar0 { get; } = new Baryon("Charmed Bottom Omega∗ 0", "Ω∗0cb", "scb", 0 /* TODO: ??? */, 0, 3 / 2, 0, -1, 1, -1, "Unknown", 3 / 2);
        public static Baryon DoubleBottomOmegaStarMinus { get; } = new Baryon("Double Bottom Omega∗-", "Ω∗−bb", "sbb", 0 /* TODO: ??? */, 0, 3 / 2, -1, -1, 0, -2, "Unknown", 3 / 2);
        public static Baryon TripleCharmedOmegaPlusPlus { get; } = new Baryon("Triple Charmed Omega++", "Ω++ccc", "ccc", 0 /* TODO: ??? */, 0, 3 / 2, 2, 0, 3, 0, "Unknown", 3 / 2);
        public static Baryon DoubleCharmedBottomOmegaStarPlus { get; } = new Baryon("Double Charmed Bottom Omega∗+", "Ω∗+ccb", "ccb", 0 /* TODO: ??? */, 0, 3 / 2, 1, 0, 2, -1, "Unknown", 3 / 2);
        public static Baryon CharmedDoubleBottomOmegaStar0 { get; } = new Baryon("Charmed Double Bottom Omega∗ 0", "Ω∗0cbb", "cbb", 0 /* TODO: ??? */, 0, 3 / 2, 0, 0, 1, -2, "Unknown", 3 / 2);
        public static Baryon TripleBottomOmegaMinus { get; } = new Baryon("Triple Bottom Omega-", "Ω−bbb", "bbb", 0 /* TODO: ??? */, 0, 3 / 2, -1, 0, 0, -3, "Unknown", 3 / 2);

        // Mesons

        // Pseudoscalar mesons

        public static Meson Pion { get; } = new Meson("Pion", "π+", "π−", "ud", 139.57018 * MeV, 1, 0, 0, 0, 0, "(2.6033±0.0005)×10^−8", 0, 0);
        public static Meson Pion0 { get; } = new Meson("Pion 0", "π0", "", "(uu-dd) / √2", 134.9766 * MeV, 1, 0, 0, 0, 0, "(8.4±0.6)×10^−17", 0, 0);
        public static Meson Eta { get; } = new Meson("Eta", "η", "", "(uu+dd-2*ss) / √6", 547.853 * MeV, 0, 0, 0, 0, 0, "(5.0±0.3)×10^−19", 0, 0);
        public static Meson EtaPrime { get; } = new Meson("Eta′", "η′ (958)", "", "(uu+dd+ss) / √3", 957.66 * MeV, 0, 0, 0, 0, 0, "(3.2±0.2)×10^−21", 0, 0);
        public static Meson CharmedEta { get; } = new Meson("Charmed Eta", "ηc (1S)", "", "cc", 2980.3 * MeV, 0, 0, 0, 0, 0, "(2.5±0.3)×10^−23", 0, 0);
        public static Meson BottomEta { get; } = new Meson("Bottom Eta", "ηb (1S)", "", "bb", 9300 * MeV, 0, 0, 0, 0, 0, "Unknown", 0, 0);
        public static Meson KaonPlus { get; } = new Meson("Kaon+", "K+", "K-", "us", 493.677 * MeV, 1 / 2, 0, 1, 0, 0, "(1.2380±0.0021)×10^−8", 0, 0);
        public static Meson Kaon0 { get; } = new Meson("Kaon 0", "K0", "K0" /* Negated */, "ds", 497.614 * MeV, 1 / 2, 0, 1, 0, 0, "Unknown", 0, 0);
        public static Meson KShort { get; } = new Meson("K-Short", "K0S", "", "(ds-sd) / √2", 497.614 * MeV, 1 / 2, 0, 0 /* Neutral Kaon */, 0, 0, "(8.953±0.005)×10^−11", 0, 0);
        public static Meson KLong { get; } = new Meson("K-Long", "K0L", "", "(ds+sd) / √2", 497.614 * MeV, 1 / 2, 0, 0 /* Neutral Kaon */, 0, 0, "(5.116±0.020)×10^−8", 0, 0);
        public static Meson DPlus { get; } = new Meson("D+", "D+", "D-", "cd", 1869.62 * MeV, 1 / 2, 0, 0, 1, 0, "(1.040±0.007)×10^−12", 0, 0);
        public static Meson D0 { get; } = new Meson("D 0", "D0", "D0" /* Negated */, "cu", 1864.84 * MeV, 1 / 2, 0, 0, 1, 0, "(4.101±0.015)×10^−13", 0, 0);
        public static Meson StrangeD { get; } = new Meson("Strange D", "D+s", "D-s", "cs", 1968.49 * MeV, 0, 0, 1, 1, 0, "(5.00±0.07)×10^−13", 0, 0);
        public static Meson BPlus { get; } = new Meson("B+", "B+", "B-", "ub", 5279.15 * MeV, 1 / 2, 0, 0, 0, 1, "(1.638±0.011)×10^−12", 0, 0);
        public static Meson B0 { get; } = new Meson("B 0", "B0", "B0" /* Negated */, "db", 5279.53 * MeV, 1 / 2, 0, 0, 0, 1, "(1.530±0.009)×10^−12", 0, 0);
        public static Meson StrangeB { get; } = new Meson("Strange B", "B0s", "B0s" /* Neagted */, "sb", 5366.3 * MeV, 0, 0, -1, 0, 1, "1.470×10^−12", 0, 0);
        public static Meson CharmedB { get; } = new Meson("Charmed B", "B+c", "B-c", "cb", 6276 * MeV, 0, 0, 0, 1, 1, "(4.6±0.7)×10^−13", 0, 0);

        // Vector mesons

        public static Meson ChargedRho { get; } = new Meson("Charged Rho", "ρ+ (770)", "ρ− (770)", "ud", 775.4 * MeV, 1, 1, 0, 0, 0, "4.5×10^−24", 0, 0);
        public static Meson NeutralRho { get; } = new Meson("Neutral Rho", "ρ0 (770)", "", "(uu-dd) / √2", 775.49 * MeV, 1, 1, 0, 0, 0, "4.5×10^−24", 0, 0);
        public static Meson Omega { get; } = new Meson("Omega", "ω (782)", "", "(uu+dd) / √2", 782.65 * MeV, 0, 1, 0, 0, 0, "(7.75±0.07)×10^−23", 0, 0);
        public static Meson Phi { get; } = new Meson("Phi", "ϕ (1020)", "", "ss", 1019.445 * MeV, 0, 1, 0, 0, 0, "(1.55±0.01)×10^−22", 0, 0);
        public static Meson JPsi { get; } = new Meson("J/Psi", "J/ψ", "", "cc", 3096.916 * MeV, 0, 1, 0, 0, 0, "(7.1±0.2)×10^−21", 0, 0);
        public static Meson Upsilon { get; } = new Meson("Upsilon", "ϒ (1S)", "", "bb", 9460.30 * MeV, 0, 1, 0, 0, 0, "(1.22±0.03)×10^−20", 0, 0);
        public static Meson KaonStar { get; } = new Meson("Kaon∗", "K∗+", "K∗−", "us", 891.66 * MeV, 1 / 2, 1, 1, 0, 0, "7.35×10^−20", 0, 0);
        public static Meson KaonStar0 { get; } = new Meson("Kaon∗ 0", "K∗0", "K∗0" /* Negated */, "ds", 896 * MeV, 1 / 2, 1, 1, 0, 0, "(7.346±0.002)×10^−20", 0, 0);
        public static Meson DStar { get; } = new Meson("D∗", "D∗+ (2010)", "D∗− (2010)", "cd", 2010.27 * MeV, 1 / 2, 1, 0, 1, 0, "(6.9±1.9)×10^−21", 0, 0);
        public static Meson DStar0 { get; } = new Meson("D∗ 0", "D∗0 (2007)", "D∗0 (2007)" /* Negated */, "cu", 2006.97 * MeV, 1 / 2, 1, 0, 1, 0, "3.1×10^−22", 0, 0);
        public static Meson StrangeDStar { get; } = new Meson("Strange D∗", "D∗+s", "D∗−s", "cs", 2112.3 * MeV, 0, 1, 1, 1, 0, "3.4×10^−22", 0, 0);
        public static Meson BStar { get; } = new Meson("B∗", "B∗+", "B∗-", "ub", 5325.1 * MeV, 1 / 2, 1, 0, 0, 1, "Unknown", 0, 0);
        public static Meson BStar0 { get; } = new Meson("B∗ 0", "B∗0", "B∗0" /* Negated */, "db", 5325.1 * MeV, 1 / 2, 1, 0, 0, 1, "Unknown", 0, 0);
        public static Meson StrangeBStar0 { get; } = new Meson("Strange B∗ 0", "B∗0s", "B∗0s" /* Negated */, "sb", 5412.8 * MeV, 0, 1, -1, 0, 1, "Unknown", 0, 0);
        public static Meson CharmedBStar { get; } = new Meson("Charmed B∗", "B∗+c", "B∗-c", "cb", 0 /* TODO: ??? */, 0, 1, 0, 1, 1, "Unknown", 0, 0);
    }
}
